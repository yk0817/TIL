# サンプル07 相対パスを絶対パスに

## スクリプト

```bash
#!/bin/sh

readonly SCRIPT_NAME=${0##*/}

path=$1

if [[ -z $path ]]; then
  printf '%s\n' "${SCRIPT_NAME}: missing file operand" 1>&2
  exit 1
fi

# パスに/がない場合、/をつける
if [[ -d $path && $path != */ ]]; then
  path+=/
fi

dir=
file=

if [[ $path =~ ^(.*/)(.*)$ ]]; then
  dir=${BASH_REMATCH[1]}
  file=${BASH_REMATCH[2]}
else
  printf '%s\n' "${PWD}/${path}"
  exit 0
fi

if [[ ! -d $dir ]]; then
  printf '%s\n' "${SCRIPT_NAME}: '$dir': No such directory" 1>&2
  exit 2
fi

basedir=$(cd -- "$dir" && pwd)
# ルートディレクトの対応
if [[ $basedir == / ]]; then
  basedir=
fi
printf '%s\n' "${basedir}/${file}"
```

## 実行例

```bash
$ bash absolute_path.sh test.txt
/Users/yamamotoken/test.txt
```

## キャプチャについて

BASH_REMATCH[1]以降はキャプチャした順番でマッチした文字列が入る
