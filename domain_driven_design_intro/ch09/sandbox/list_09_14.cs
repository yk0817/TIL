public class User
{
  private readonly UserId id;
  // 略
  
  // ファクトリとして機能するメソッド
  public Circle CreateCircle(CircleName circleName)
  {
    return new Circle (
      id,
      circleName
    );
  }
}