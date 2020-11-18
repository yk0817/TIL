# サンプル03 指定したユーザの情報を出力

## スクリプト(userinfo.sh)

```bash
#! /bin/bash

readonly SCRIPT_NAME=${0##*/}

user=$1

if [[ -z $user ]]; then
  printf '%s\n' "${SCRIPT_NAME}: missing username" 1>&2
  exit 1
fi

cat /etc/passwd \
  | grep "^${user}:" \
  | {
      IFS=: read -r username password userid groupid \
                      comment homedirectory loginshell

      if [[ $? -ne 0 ]]; then
        printf '%s\n' "${SCRIPT_NAME}: '$user': No such user" 1>&2
        exit 2
      fi

      cat <<END
username = $username
userid = $userid
groupid = $groupid
homedirectory = $homedirectory
loginshell = $loginshell
END
  }
```

## 実行例

```bash
$ bash ./userinfo.sh root                                                                                                                                                                                                 09:15:20
username = root
userid = 0
groupid = 0
homedirectory = /var/root
loginshell = /bin/sh
```

## /etc/passwd

意味: ユーザの管理をつかさどっているファイル

[2.2 パスワードファイル /etc/passwd の構造](https://www.wakhok.ac.jp/biblion/1997/sysadmin/node18.html)

## if文いろいろ

$?は直前のコマンド実行を表す。read正常終了の場合、0を返す。
プログラム上readで正常終了した場合は何も実行しない

## 比較的まとまっているオプション記事

[Bash の if 文（test文）のオプションを整理してみた - Qiita](https://qiita.com/wakayama-y/items/a9b7380263da77e51711)
