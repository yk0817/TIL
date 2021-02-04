# エンティティ

## エンティティの性質について

- 可変である
- 同じ属性であっても区別される
- 同一性によって区別される

値オブジェクトの性質はことなる。

### 可変である

すべての属性を可変にする必要はなく、必要に応じて(エンティティ)値を可変に出来る。

### 同じ属性であっても区別される

識別子(例えばid)でエンティティを区別

### 同一性をもつ

値オブジェクトの比較処理では、すべての属性が比較の対象となっていたが、
エンティティの比較処理では識別子(id)だけが比較対象となる。

## エンティティの判断基準としてのライフサイクルと連続性