# サンプル02 数値一覧の合計
## スクリプト

```bash
#!/bin/sh

readonly SCRIPT_NAME=${0##*/}

result=0

while IFS= read -r number
do
  if [[ ! $number =~ ^-?[0-9]+$ ]]; then
    printf '%s\n' "${SCRIPT_NAME}: '$number': non-integer number" 1>&2
    exit 1
  fi

  ((result += number))
done

printf '%s\n' "$result"
```

## readコマンド

**書式:**  read 変数名1 変数名2


```bash
#! /bin/bash
# 参考: https://www.atmarkit.co.jp/ait/articles/1811/28/news003.html
read -p "input word > " word
echo $word
```

## IFS変数

区切り文字(通常はタブ、改行など)
https://www.server-memo.net/shellscript/ifs.html

## スクリプトを使った応用

```bash
# ファイル一覧の合計値を取得
$ ls -l | tail -n '+2' | sed 's/ \{2,\}/ /g' | cut -d ' ' -f 5 | ./sumlines.sh
1413
```

### 解説
```bash
# ファイルの詳細出力をすると以下のような出力となる
$ ls -l
# total 5761616
# drwx------@   4 yamamotoken  staff         128  6 30  2018 Applications
# ...

# 先頭から数えて2行目以降を取得
$ ls -l | tail -n +2
# drwx------@   4 yamamotoken  staff         128  6 30  2018 Applications
# ...

# 何個もある空白を空白1つにする。メタ文字なので \ をつける
$ ls -l | tail -n +2 | sed 's/ \{2,\}/ /g'
# drwx------@ 4 yamamotoken staff 128 6 30 2018 Applications
# ...

# 区切り文字(dオプション)をつかって5列目を取得
$ ls -l | tail -n +2 | sed 's/ \{2,\}/ /g'| cut -d ' ' -f 5
# 128
# 128
# 192
# ...
```
