class User
{
  public User(UserName name)
  {
    if (name == null) throw new ArgumentException(nameof(name));
    Id = new UserId(Guid.NewGuid().ToString());
    name = name;
  }

  public UserId Id { get; }
  public UserName Name { get; }
}
