public class UserRepository : IUserRepository
{
  private readonly SqlConnection connection;
  private readonly UserApplicationService userService;
  private readonly IUserFactory userFactory;
  private readonly IUserRepository userRepository;

  public UserApplicationService(SqlConnection connection, UserApplicationService userService, IUserFactory userFactory, IUserRepository userRepository)
  {
    this.connection = connection;
    this.userService = userService;
    this.userFactory = userFactory;
    this.userRepository = userRepository;
  }

  public void Register(UserRegisterCommand command)
  {
    using(var transaction = connection.BeginTransaction())
    {
      var userName = new UserName(command.Name);
      var user = userFactory.Create(userName);

      if (userService.Exists(user))
      {
        throw new CanNotRegisterUserException(user, "ユーザは既に存在しています");
      }
      userRepository.Save(user, transaction);
      transaction.Commit();
    }
  }

  public UserRepository(SqlConnection connection)
  {
    this.connection = connection;
  }

  public void Save(User user, SqlTransaction transaction = null)
  {
    using (var command = connection.CreateCommand())
    {
      if (transaction != null)
      {
        command.Transaction = transaction;
      }
      command.CommandText = @"
      USING (
        SELECT @id AS id, @name AS name
      ) AS data
      ON users.id = data.id
      WHEN MATCHED THEN
        UPDATE SET name = data.name
      WHEN NOT MATCHED THEN
        INSERT (id, name)
        VALUES (data.id, data.name);
      ";
      command.Parameters.Add(new SqlParameter("@id", user.Id.Value));
      command.Parameters.Add(new SqlParameter("@name", user.Name.Value));

      command.ExecuteNonQuery();
    }
  }
}