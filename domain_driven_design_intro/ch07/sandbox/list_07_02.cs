public interface IUserRepository
{
  User Find(UserId id);
}

public class UserRepository : IUserRepository
{
  public User Find(UserId id)
  {
    // ...
  }
}
