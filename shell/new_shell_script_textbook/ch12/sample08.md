# サンプル08 複数のファイルから文字列を検索する

## スクリプト

```bash
#!/bin/bash

readonly SCRIPT_NAME=${0##*/}

pattern=$1
directory=$2

if [[ -z $pattern ]]; then
  printf '%s\n' "${SCRIPT_NAME}: missing search pattern" 1>&2
  exit 1
fi

if [[ -z $directory ]]; then
  directory=.
fi

if [[ ! -d $directory ]]; then
  printf '%s\n' "${SCRIPT_NAME}: '$directory': No such directory" 1>&2
  exit 2
fi

find -- "$directory" -type f -print0 | xargs -0 grep -e "$pattern" -- /dev/null
```

## 実行例

```bash
$ bash findgrep.sh YES ./
.//hogehoge:        enabled: yes
```

## null文字許可
null文字許可を行い、ファイル出力をnull文字区切りにすることによってスペースのあるファイル名が区切られないようにする。

- find -print0
  - findをnull文字区切りで出力する
- xargs -0
  - 標準入力の区切り文字をnullにする。
