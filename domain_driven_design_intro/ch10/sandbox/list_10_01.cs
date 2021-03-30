public class UserApplicationService
{
  private readonly IUserFactory userFactory;
  private readonly IUserRepository userRepository;
  private readonly UserService userService;
  //略
  public void Register(UserRegisterCommand command)
  {
    var userName = new UserName(command.Name);
    var user = userFactory.Create(userName);

    if (userService.Exists(user))
    {
      throw new CanNotRegisterUserException(user, "ユーザは既に存在してます。");
    }

    userRepository.Save(user);
  }
}