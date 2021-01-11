# 概要

学んだことをメモ的に書いていく

## merge

[公式doc](https://docs.ruby-lang.org/ja/latest/method/Hash/i/merge.html)

知らなかったのは以下の記述
> merge(*others) {|key, self_val, other_val| ... } -> Hash
ブロック付きにするとkeyに対応した値を返す

```ruby
# ex)
irb(main):001:0> old_hash = { a: 1, b: 2, c:2}
=> {:a=>1, :b=>2, :c=>2}
irb(main):002:0> new_hash = { a: 2, c: 3}
=> {:a=>2, :c=>3}
irb(main):003:0> old_hash.merge(new_hash){|key, old_val, new_val| old_val + new_val}
=> {:a=>3, :b=>2, :c=>5}
```
