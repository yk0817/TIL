# アプリケーションを1から組み立てる

## 題材とする機能
ユーザー同士の交流を促すための機能としてのサークル機能

## サークルの前提条件
- サークル名は3文字以上20文字以下
- サークル名はすべてのサークルで重複しない
- サークルに所属するユーザの最大数はオーナ含めて30名まで

## サークルの知識やルールをオブジェクトとして準備
サークルはライフサイクルをもつオブジェクトなので、エンティティで表現(詳しくはP58)

```
# サークルの識別子となる値オブジェクト
public class CircleId
{
  public CircleId(string value)
  {
    if (value == null) throw new ArgumentNullException(nameof(value));

    Value = value;
  }
  
  public string Value { get; }
}
```

```
# サークルの名前を表す値オブジェクト
public class CircleName : IEquatable<CircleName>
{
  public CircleName(string value)
  {
    if (value == null) throw new ArgumentNullException(nameof(value));
    if (value.Length < 3) throw new ArgumentException("サークル名は3文字以上です", nameof(value));
    if (value.Length > 20) throw new ArgumentException("サークル名は20文字以下です。" nameof(value));
    Value = value; 
  }
  public string Value { get; }

  public bool Equals(CircleName other)
  {
    if (ReferenceEquals(null, other)) return false;
    if (ReferenceEquals(this, obj)) return true;
    if (obj.GetType() != this.GetType()) return false;
    return Equals((CircleName) obj);
  }

  public override int GetHashCode()
  {
    return (Value != null ? Value.GetHashCode() : 0);
  }
}
```

```
# サークルを表すエンティティ
public class Circle
{
  public Circle(CircleId id, CircleName name, User owner, List<User> members)
  {
    if (id == null) throw new ArgumentNullException(nameof(id));
    if (name == null) throw new ArgumentNullException(nameof(name));
    if (owner == null) throw new ArgumentNullException(nameof(owner));
    if (members == null) throw new ArgumentNullException(nameof(members));
    Id = id;
    Name = name;
    Owner = owner;
    Members = members;
  }

  public CircleId Id { get; }
  public CircleName Name { get; private set; }
  public User Owner { get; private set; }
  public List<User> Members { get; private set; }
}
```