# モデリングから実装まで

## ドメインモデリング

DDDに着手して迷うのはモデリングの方法やアウトプットの形式
色々な方法があるが、ユースケース図やドメインモデル図が比較的シンプルかつ初めてでも効果的

- ユースケース図
  - ユーザの要求に対するシステムの振る舞いを定義する図
  - ユースケース図を作成する目的
    - どのようなモデルを作ればいいか、明確にするため
  - スコープを決める目的
    - 議論の範囲を狭めて限られた時間で成果を出すため
- ドメインモデル図
  - 簡略化したクラス図のようなもの
    - モデリングで個人的に使えそうな箇所
      - ルール/ドメイン知識は吹き出しに書き出す
      - 集約の範囲を定義する
      - 具体例を書いてもいい

## ドメインモデルの実装

- ドメインモデルでよくある問題点
  - 不整合なデータをいくらでも作れる
  - ドメイン知識がちらばっている

## ドメインモデルの基本方針

- ドメインモデルの知識を対応するオブジェクトに書く
  - ex) ドメイン知識はドメイン層に書く
- 常に正しいインスタンスしか存在させない