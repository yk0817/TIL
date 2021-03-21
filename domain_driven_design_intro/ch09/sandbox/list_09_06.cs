public class UserApplicationService
{
  private readonly IUserFactory userFactory;
  private readonly IUserRepository userRepository;
  private readonly UserService userService;

  // 略

  public void Register(UserRegisterCommand command)
  {
    var userName = new UserName(command.Name);
    // factory
    var user = userFactory.Create(userName);
    if (userService.Exsits(user))
    {
      throw new CanNotRegisterUserException(user);  
    }

    userRepository.Save(user);
  }
}