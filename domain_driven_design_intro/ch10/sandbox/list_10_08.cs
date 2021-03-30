public class UserApplicationService {
  private final UserRepository userRepository;
  private final UserFactory userFactory;
  private final UserService userService;
  // 略

  @Transactional
  public void Register(UserRegisterCommand command) {
    UserName userName = new UserName(command.getName());
    User user = userFactory.create(userName);

    if (userService.exists(user))
    {
      throw new CanNotRegisterUserException(user, "ユーザは既に存在しています。");
    }

    userRepository.save(user);
  }
}