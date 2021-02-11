public class UserApplicationService
{
  private readonly IUserRepository userRepository;
  private readonly UserService userService;

  public UserApplicationService(IUserRepository userRepository, UserService userService)
  {
    this.userRepository = userRepository;
    this.userService = userService;
  }

  public void Register(string name)
  {
    var user = new User(
      new UserName(name)
    );
    if (userService.Exists(user))
    {
      throw new CanNotRegisterUserException(user, "ユーザは既に存在しています");
    }

    userRepository.Save(user);
  }

  public UserData Get(string userId)
  {
    var targetId = new UserId(userId);
    if (user == null)
    {
      return null;
    }

    return new UserData(user);
  }

  public void Update(UserUpdateCommand command)
  {
    var targetId = new UserId(command.Id);
    var user = userRepository.Find(targetId);
    if (user == null)
    {
      throw new UserNotFoundException(targetId);
    }

    var name = command.Name;
    if (name != null)
    {
      var newUserName = new UserName(name);
      user.ChangeName(newUserName);

      if (userService.exists(user))
      {
        throw new CanNotRegisterException(user, "ユーザは既に存在しています");
      }
    }

    var mailAddress = command.MailAddress;
    if (mailAddress != null)
    {
      var newMailAddress = new MailAddress(mailAddress);
      user.ChangeMailAddress(newMailAddress);
    }

    userRepository.Save(user);
  }

  public void Delete(UserDeleteCommand command)
  {
    var targetId = new UserId(targetId);
    var user = userRepository.Find(targetId);

    if (user == null)
    {
      // 対象が見つからなかった
      return;
    }

    userRepository.Delete(user);
  }

  public void Register(string name, string mailAddress)
  {
    var user = new User(
      new UserName(name),
      new MailAddress(mailAddress)
    );
    if (userService.Exists(user))
    {
      throw new CanNotRegisterUserException(user, "ユーザは既に存在しています")
    }

    userRepository.Save(user);
  }
}
