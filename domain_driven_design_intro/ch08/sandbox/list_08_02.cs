class Program
{
  private static ServiceProvider serviceProvider;
  static void Main(string[] args)
  {
    Startup();

    while (true)
    {
      Console.WriteLine("Input user name");
      Console.Write(">");
      var input = Console.ReadLine();
      var userApplicationService = serviceProvider.GetService<userApplicationService>();
      var command = new UserRegisterCommand(input);
      userApplicationService.Register(command);

      // ...略
    }
  }
}