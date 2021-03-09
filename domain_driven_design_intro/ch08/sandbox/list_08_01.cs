class Program
{
  private static ServiceProvider serviceProvider;

  static void Main(string[] args)
  {
    Startup();
    // 
  }

  private static void Startup()
  {
    // IoC Container
    var serviceCollection = new serviceCollection();
    // 依存関係の登録を行う。
    serviceCollection.AddSingleton<IUserRepository, InMemoryUserRepository>();
    serviceCollection.AddTransient<UserService>();
    serviceProvider = serviceProvider.BuildServiceProvider();
  }
}