# reshape
## 基本的な用法

配列の形状を変更する

```python
>>> np.arange(6).reshape((3, 2))
array([[0, 1],
       [2, 3],
       [4, 5]])
>>> np.arange(6).reshape((2, 3))
array([[0, 1, 2],
       [3, 4, 5]])
```

[numpy.reshape - NumPy v1.19 Manual](https://numpy.org/doc/stable/reference/generated/numpy.reshape.html)

## numpy tips

### 第1引数が-1の時、第2引数の長さの配列を複数作成

```python
>>> np.arange(6).reshape(-1, 2)
array([[0, 1],
       [2, 3],
       [4, 5]])
>>> np.arange(6).reshape(-1, 3)
array([[0, 1, 2],
       [3, 4, 5]])
```

参考にした箇所:

[numpyのarangeとreshapeをよく忘れるので個人的メモ - Qiita](https://qiita.com/kaba/items/4f946e90926801aecd64)
