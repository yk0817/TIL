public class UserApplicationService
{
  private readonly IUserRepository userRepository;

  public UserApplicationService()
  {
    this.userRepository = ServiceLocator.Resolve<IUserRepository>();
  }
}
