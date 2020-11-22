# サンプル06 指定したファイルとその途中のディレクトリを作成

## スクリプト例

```bash
#!/bin/bash

readonly SCRIPT_NAME=${0##*/}

dtouch_one()
{
  local path=$1

  if [[ -z $path ]]; then
    printf '%s\n' "${SCRIPT_NAME}: missing file operand" 1>&2
    return 1
  fi

  local dir=
  if [[ $path == */* ]]; then
    dir=${path%/*}
  fi

  if [[ -n $dir && ! -d $dir ]]; then
    mkdir -p -- "$dir" || return 2
  fi

  if [[ ! -e $path ]]; then
    touch -- "$path"
  fi
}

if [[ $# -le 0 ]]; then
  printf '%s\n' "${SCRIPT_NAME}: missing file operand" 1>&2
  exit 1
fi

result=0

for i in "$@"
do
  dtouch_one "$i" || result=$?
done

exit "$result"
```

## 実行例

```bash
# ディレクトリからファイルまで作ってくれる
$ bash test.sh hoge/test.sh
$ ls hoge/
test.sh
```

## 条件分岐のオプション

- dオプション
  - ディレクトリならtrue
- nオプション
  - 文字列長が 0 より大ならtrue

## パターンを指定して切り出す

- ${変数名#パターン}
  - 最短マッチ
- ${変数名%パターン}
  - 最長マッチ

```bash
# 最長マッチ
$ path=/var/hoge/hoge/
$ echo ${path%/*}
/var/hoge/hoge
```
