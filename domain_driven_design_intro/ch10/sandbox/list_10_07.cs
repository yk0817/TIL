public class UserApplicationService
{
  private readonly UserApplicationService userApplicationService;
  private readonly IUserFactory userFactory;
  private readonly IUserRepository userRepository;

  public UserApplicationService(UserApplicationService userService, IUserFactory userFactory, IUserRepository userRepository)
  {
    this.userService = userService;
    this.userFactory = userFactory;
    this.userRepository = userRepository;
  }

  public void Register(UserRegisterCommand command)
  {
    using(var transactin = new TransactionScope())
    {
      var userName = new UserName(command.Name);
      var user = userFactory.Create(userName);

      if (userService.Exists(user))
      {
        throw new CanNotRegisterUserException(user, "ユーザは既に存在しています。");
      }

      userRepository.Save(user);
      transaction.Complete*(;)
    }
  }
  // 略
}