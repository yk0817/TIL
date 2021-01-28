# 値オブジェクト

値オブジェクトとはシステム固有の値を表したオブジェクト

## 値オブジェクトの性質

値の性質
- 不変である
- 交換が可能
- 等価性によって比較される

### 不変である

値オブジェクトはシステム固有の値を表しているため、不変である必要がある。
本の例でいうと、↓の例はやりがちだが、不変性を満たしていない。

```cs
var FullName = new FullName("masanobu", "naruse")
fullName.ChangeLastName("sato");
```

### 交換が可能

値を変更するには↓のようにする

```cs
var FullName = new FullName("masanobu", "naruse");
fullName = new FullName("masanobu", "sato");
```

### 等価性によって比較される

等価とは、値自身ではなく、構成する属性(クラスならインスタンス変数)で比較されること

## 値オブジェクトにする基準
どこまでを値オブジェクトにするかは難しい問題
例えば、./sandbox/list_02_18.cs ではfirstNameやlastNameはプリミティブな文字列になっている。

著者の考える判断基準
- そこにルールが存在しているか
  - 氏名 → 性と名で構成される
- 単体で取り扱いたいのか
  - 文字制限があるなど...。氏名(FullName)の場合、validationをつけるなど出来る。

## ふるまいを持った値オブジェクト
独自のふるまいを定義出来る

```cs
// jpy同士の足し算→ok
var myMoney = new Money(1000, "JPY");
var allowance = new Money(3000, "JPY");
var result = myMoney.Add(allowance)

// jpy、usの足し算、プリミティブだと例外は出ない
var jpy = new Money(1000, "JPY");
var usd = new Money(10, "USD");
var result = jpy.Add(usd); // 例外が出る
```

定義しないと、使えないため処理を一箇所にまとめられる

## 値オブジェクトを採用するモチベーション
- 表現力を増す
- 不正な値を存在させない
- 誤った代入を防ぐ
- ロジックの散在を防ぐ

値オブジェクトはプリミティブでなく、オブジェクトを介して処理を行うため、
適切にかけば、validationはオブジェクト化するclassに書く、処理を一箇所にまとめたり出来る。
結果としてドキュメントをコードにまとめることが出来る

## 外部リンク

[IEqualtable doc])(https://docs.microsoft.com/ja-jp/dotnet/api/system.iequatable-1?view=net-5.0)
[DDD に入門するなら、まずは ValueObject だけでもいいんじゃない？
](https://qiita.com/t2-kob/items/9d9dd038fe7497756dbf)
[IEquatableを完全に理解する
](https://qiita.com/cactuaroid/items/f277a097ecf51eb247c0)
[.NET マイクロサービス: コンテナー化された .NET アプリケーションのアーキテクチャは勉強になりそう](https://docs.microsoft.com/ja-jp/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/implement-value-objects#important-characteristics-of-value-objects)
