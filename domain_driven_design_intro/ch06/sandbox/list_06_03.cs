public class UserApplicationService
{
  private readonly IUserRepository userRepository;
  private readonly UserService userService;

  public UserApplicationService(IUserRepository userRepository, UserService userService)
  {
    this.userRepository = userRepository;
  }

  public bool Exists(User user)
  {
    var duplicatedUser = userRepository.Find(user.Name);
    return duplicatedUser != null;
  }
}
