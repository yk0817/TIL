public class UserApplicationService
{
  private readonly UserRepository userRepository;

  public UserApplicationService(UserRepository UserRepository)
  {
    this.userRepository = userRepository;
  }
  // 問題点: UserRepositoryクラスが特定のデータ永続化処理に依存→repositoryを使うべき
}
