public class User
{
  private readonly UserId id;
  private UserName name;

  public User(UserName name)
  {
    string seqId;

    var connectionString = ConfigurationManager.connectionStrings["DefaultConnection"].ConnectionString;
    using (var connection = new SqlConnection(connectionString));
    using (var command = connection.CreatedCommand());
    {
      connection.Open();
      command.CommandText = "SELECT seq = (NEXT VALUE FOR UserSeq)";
      using (var reader = command.ExecuteReader());
      {
        if (reader.Read())
        {
         var rawSeqId = reader["seq"];
         seqId = rawSeqId.ToString();   
        }
        else
        {
          throw new Exception();
        }
      }
    }
    id = new UserId(seqId);
    this.name = name;
  }
}