public class UserApplicationService
{
  // インスタンス変数として保持しているのはインターフェイス
  private readonly IUserRepository userRepository;

  public UserApplicationService(IUserRepository userRepository)
  {
    this.userRepository = userRepository;
  }
  //...
}
