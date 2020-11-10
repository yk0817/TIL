# サンプル01 数値の合計

## スクリプト: 数値の合計値を計算する

```bash
#! /bin/bash

# シェルスクリプトのファイル名を取り出して変数に代入している
readonly SCRIPT_NAME=${0##*/}

result=0

for number in "$@"
do
  if [[ ! $number =~ ^-?[0-9]+$ ]]; then
    printf '%s\n' "${SCRIPT_NAME}: '$number': non-integer number" 1>&2
    exit 1
  fi

  ((result+=number))
done

printf '%s\n' "$result"
```

## readonly SCRIPT_NAME=${0##*/}
  スクリプト名を取得する処理

### 処理フロー
-1. $0: 実行しているシェルスクリプトのパス を取得
-2. ${parameter##word}  先頭から前方最長一致した位置まで取り除く

**参考文献:**

[https://pikesaku.hatenablog.com/entry/2016/12/18/122814](https://pikesaku.hatenablog.com/entry/2016/12/18/122814)

## $@

シェルの特殊変数を表し、スクリプトに渡された引数全てを表示します


```bash
#!/bin/sh
# $ bash test.sh hoge hoge2
# $ hoge hoge2

echo $@
```

## for文

```bash
#!/bin/sh

for count in `seq 1 10`
do
  echo $count
done
```

## if文

```bash

# if文の書き方は以下のような形
# if [ 条件1 ]; then
# 処理1
# elif [ 条件2 ]; then
# 処理2
# else
# 処理3
# fi
```
