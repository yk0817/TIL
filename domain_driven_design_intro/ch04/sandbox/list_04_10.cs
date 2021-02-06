class UserId
{
  public UserId(string value)
  {
    if (value == null) throw new ArgumentNullException(nameof(value));
    Value = value;
  }
  public string Value { get; }
}

class UserName
{
  public UserName(string value)
  {
    if (value == null) throw new ArgumentNullException(nameof(value));
    if (value.Length < 3) throw new ArgumentNullException("ユーザ名は3文字以上です", nameof(value));
    Value = value;
  }
  public string Value { get; }
}
