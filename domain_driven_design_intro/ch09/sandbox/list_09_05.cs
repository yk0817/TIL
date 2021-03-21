public class User
{
  private readonly UserId id;
  private UserName name;

  public User(UserId id, UserName name)
  {
    if (id == null) throw new ArgumentNullException(nameof(id));
    if (name == null) throw new ArgumentNullException(nameof(name));
    this.id = id;
    this.name = name;
  }
  // 略...
}