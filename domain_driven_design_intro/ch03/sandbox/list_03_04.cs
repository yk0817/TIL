class UserId
{
  private string value;

  public UserId(string value)
  {
    if (value == null) throw new ArgumentNullException(nameof(value));
    this.value = value;
  }
}

class User
{
  private readonly UserId id;
  private string name;

  public User(UserId id, string name)
  {
    if (id == null) throw new ArgumentNullException(nameof(id));
    if (name == null) throw new ArgumentNullException(nameof(name));

    this.id = id;
    this.name = name;
  }
}
