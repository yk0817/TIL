// IoC Container
var serviceCollection = new ServiceCollection();
// 依存解決の設定を登録する
serviceCollection.AddTransient<IUserRepository, InMemoryUserRepository>();
serviceCollection.AddTranssient<UserApplicationService>();

// インスタンスはIoC Container経由で取得する
var provider = serviceCollection.BuildServiceProvider();
var UserApplicationService = provider.GetService<UserApplicationService>();
