# 展開とクォーティング

## パラメータ展開

### :-による展開

#### コマンド

```bash
# nameを定義していない状態
$ echo ${name:-miyake}
miyake
# nameを定義した場合
$ name=hoge
$ echo ${name:-miyake}
hoge
```
#### 実際の利用例

```
#!/bin/bash
# デフォルトディレクトリを表示
ls ${1:-/}
```

### :=の展開
デフォルト値を設定するために使われる
```bash
echo ${name:=miyake}
miyake
$ echo $name
miyake
$ name=hoge
echo ${name:=miyake}
hoge
```
### :?による展開

:?は変数に値が設定されていない場合、エラー制御をするもの

```bash
$ cd ${hoge:?you must set hoge}
bash: hoge: you must set hoge
```
### 文字数に展開
```bash
$ name=/usr/hoge/
$ echo ${#name}
10
```
### パターン切り出し

- ${変数名#パターン}
  - パターンに前方一致した部分の残りを展開
- ${変数名%}
  - パターンに後方一致した部分を除く

#### 変数名#パターン

```bash
# 最短マッチ
$ pref1=Aomori
$ echo ${pref1#Ao}
mori
# 最短マッチしない場合
$ pref2=Akita
$ echo ${pref2#Ao}
Akita
# 拡張子を取り出す
$ file=home.tar.gz
$ echo ${file#*.}
tar.gz
# 最長マッチ
$ echo ${file##*.}
gz
```

#### 変数名%パターン

```bash
$ file=home.tar.gz
$ echo ${file$.*}
home.tar
$ file=home.tar.gz
$ echo ${file%%.*}
home
```
