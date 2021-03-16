publc class Startup
{
  public void ConfigureServices(IServiceCollection services)
  {
    services.AddControllersWithViews();

    services.AddSpaStaticFiles(Configuration => {
      Configuration.RootPath = "ClientApp/build";
    });

    // リポジトリやアプリケーションサービスの依存解決を設定する
    services.AddSingleton<IUserRepository, InMemoryUserRepository>();
    services.AddTransient<UserService>();
    services.AddTransient<UserApplicationService>();
  }
}