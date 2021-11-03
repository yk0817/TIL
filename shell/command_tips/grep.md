# grep
わすれがちなのでメモ

## or検索

```
# Eオプション(正規表現)を使う
$ grep -nrE "tes?t|hog{2}e"
$ eオプション(一致)を使う
$ grep -nr -e "test" -e "hoge"
```

## 大文字小文字関係なく検索
```
#  --ignore-case でも可能
$ grep -i test test.txt
```
## ファイル形式を指定

```
$ grep -nrE "testtest|test" .  --include=\*.py
```
