# サンプル05 ファイル形式を判別して圧縮ファイルを展開

## スクリプト例

```bash
#! /bin/bash

# 圧縮されたファイルを展開する

readonly SCRIPT_NAME=${0##*/}

extract_one()
{
  local file=$1

  if  [[ -z $file ]]; then
    printf '%s\n' "${SCRIPT_NAME}: missing file operand" 1>&2
    return 1
  fi

  if  [[ ! -f $file ]]; then
    printf '%s\n' "${SCRIPT_NAME}: '$file': No such file" !>&2
    return 2
  fi

  local base="${file%.*}"

  case "$file" in
    *.tar.gz | *.tgz)
      tar xzf "$file"
      ;;
    *.tar.bz2 | *.tbz2)
      tar xjf "$file"
      ;;
    *.tar.xz | *.txz)
      tar xJf "$file"
      ;;
    *.tar)
      tar xf "$file"
      ;;
    *.gz)
      gzip -dc -- "$file" > "$base"
      ;;
    *.bz2)
      bzip2 -dc -- "$file" > "$base"
      ;;
    *.xz)
      xz -dc -- "$file" > "$base"
      ;;
    *.zip)
      unzip -q -- "$file"
      ;;
    *)
      print '%s\n' "${SCRIPT_NAME}: '$file': unexpected file type" 1>&2
      return 3
      ;;
  esac
}

if [[ $# -le 0 ]]; then
  printf '%s\n' "${SCRIPT_NAME}: missing file operand" 1>&2
  exit 1
fi

result=0

for i in "$@"
do
  extract_one "$i" || result=$?
done

exit "$result"
```

## 実行例

```bash
$ touch test.csv
# zip化
$ gzip test.csv
# 圧縮したファイルを解答
$ sh test.sh test.csv.gz
$ ls | grep test.csv
test.csv
```

## 条件分岐のオプション

zオプション:  string の文字列長が0ならtrue

```bash
# 標準入力に何もなかったら
if [[ -z ~ ]]; then
 echo "standard input not found"
fi
```

fオプション: 通常のファイルならtrue

leオプション:  (lesser or equal)  例) if [[ 1 -le 0]]; then

## case文

```bash
case 値 in
  パターン1 )
    処理1
    ;;
  パターン2 )
    処理2
    ;;
  …
  パターンn )
    処理n
    ;;
esac
```

シェル例

```bash
#! /bin/bash
# 実行すると1が出力される

var=1

case "$var" in
  "0")
    echo "0"
    ;;
  "1")
    echo "1"
    ;;
esac
```

[https://shellscript.sunone.me/case.html](https://shellscript.sunone.me/case.html) より

## $#と$@

```bash
- $@ → 全ての標準入力できた引数を取得
- $# → 全ての標準引数の個数を取得
```
