public class User
{
  private readonly UserId id;
  private UserName name;

  public User(UserName name)
  {
    if (name == null) throw new ArgumentNullException(nameof(name));
    // GUID(Global Unique Identifier)を利用して識別子を生成している
    id = new UserId(Guid.NewGuid().ToString());
    this.name = name;
  }

  public User(UserId id, UserName name)
  {
    if (id == null) throw new ArgumentNullException(nameof(id));
    if (name == null) throw new ArgumentNullException(nameof(name));
    this.id = id;
    this.name = name;
  }
  // ...
}