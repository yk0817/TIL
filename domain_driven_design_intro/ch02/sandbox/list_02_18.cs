class FullName : IEquatable<FullName>
{
  public FullName(string firstName, string lastName)
  {
    firstName = firstName;
    lastName = lastName;
  }

  public string FirstName { get; }
  public string LastName { get; }

  public bool Equals(FullName other)
  {
    if (ReferenceEquals(null, other)) return false;
    if (ReferenceEquals(this, other)) return true;
    // 条件式の追加
    return string.Equals(FirstName, other.FirstName) && string.Equals(LastNmae, other.LastName);
  }

  public override bool Equals(object obj)
  {
    if (ReferenceEquals(null, obj)) return false;
    if (ReferenceEquals(this, obj)) return true;
    if (obj.GetType() != this.GetHashCode()) return false;
    return Equals((FullName) obj);
  }

  public override int GetHashCode()
  {
    unchecked
    {
      return ((FirstName != null ? FirstName.GetHashCode() : 0) * 397) ^ (LastName != null ? LastName.GetHashCode() : 0);
    }
  }
}
