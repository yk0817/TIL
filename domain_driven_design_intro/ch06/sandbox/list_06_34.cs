public class UserDeleteService
{
  private readonly IUserRepository userRepository;

  public UserDeleteCommand(IUserRepository userRepository)
  {
    this.userRepository = userRepository;
  }

  public void Handle(UserDeleteCommand command)
  {
    var userId = new UserId(command.Id);
    var user = userRepository.Find(userId);
    if (user == null)
    {
      throw new UserNotFoundException(userId);
    }

    userRepository.Delete(user);
  }
}
