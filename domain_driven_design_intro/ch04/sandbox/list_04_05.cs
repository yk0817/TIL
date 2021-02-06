var userService = new UserService();

var userId = new UserId("id");
var userName = new UserName("naruse");
var user = new User(userId, userName);

// ドメインサービスに問い合わせ
var duplicateCheckResult = userService.Exists(user);
Console.WriteLine(duplicateCheckResult);
