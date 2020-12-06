# 変数

## 環境変数
- printenv
  - ターミナルで実行すると現在の環境変数一覧を表示

## 特殊なシェル変数

- path
  - シェルがコマンドを探すディレクトリを指定するための変数

## 位置パラメータ

```bash
#!/bin/bash

# パスも含めたファイル名を出力
echo $0
echo $1
echo $2
# スペースで結合した引数を出力
echo $*
# それぞれ一つの引数として出力
# 多くの場合、$*でなく、$@使う
echo $@
```

## declareによる変数宣言

### オプション
```bash
# declareオプション
-r: 変数を読み取り
-i: 変数を整数として扱う
-a: 変数を配列として扱う
-A: 変数を連想配列として扱う
```

### コマンド例
```
# 変数読み取り
$ name=file1
$ declare -r name
$ name=hoge
bash: name: readonly variable
# 変数を整数として扱う
$ declare -i sum
$ sum=1+1
$ echo $sum
2
```

## 配列

```
ary=(1 2)
echo ${ary[0]}
1
echo ${ary[1]}
2
# 値を変更
ary[1]=3
echo ${ary[1]}
3
# すべての値を出力
$ echo ${ary[*]}
1 2
$ echo ${ary[@]}
1 2
```

