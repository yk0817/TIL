public class Startup
{
  public Startup(IConfiguration configuration)
  {
    configuration = configuration;
  }

  public IConfiguration Configuration { get; }

  public void ConfigureServices(IServiceCollection services)
  {
    services.AddControllersWithViews();
    services.AddSpaStaticFiles(Configuration => {
      Configuration.RootPath = "ClientApp/build";
    });
  }
  // 略
}