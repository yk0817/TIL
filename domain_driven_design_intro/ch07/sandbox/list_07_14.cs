var userRepository = new InMemoryUserRepository();
// オブジェクトを注入しているDI

var UserApplicationService = new UserApplicationService(userRepository);
