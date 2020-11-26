# リンクを新しいタブで開くとき、rel="noopener"をつけたほうが良い

## 内容
以下のようなタグを埋め込むと、外部リンクを新しいタブで表示出来る

```
<a href="https://www.yahoo.co.jp" target="_blank">link</a>
```

ただ、この場合、セキュリティ問題を引き起こす可能性がある。
理由としては、[この記事](https://webtan.impress.co.jp/e/2020/03/13/35510)にある通り、
リンク先のページに悪意のあるプログラムがある場合、[window.opener](https://developer.mozilla.org/ja/docs/Web/API/window.opener) を用いて、
リンク元のページを改ざんする可能性があるため。

そこでrel属性を用いて、noopenerとしてリンク元を改ざんできないようにすれば良い

```
<a href="https://www.yahoo.co.jp" rel="noopener">link</a>
```
