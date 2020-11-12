# grep
わすれがちなのでメモ

## or検索

```
# Eオプション(正規表現)を使う
$ grep -nrE "tes?t|hog{2}e"
$ eオプション(一致)を使う
$ grep -nr -e "test" -e "hoge"
```

## ファイル形式を指定

```
$ grep -nrE "testtest|test" .  --include=\*.py
```
