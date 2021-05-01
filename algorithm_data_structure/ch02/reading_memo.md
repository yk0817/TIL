# 計算量とオーダー記法

## 計算量とは

良いアルゴリズムか、判断する基準として重要な概念として**計算量(computational complexity)** 

がある。

計算量を学ぶ利点: コンピュータ上での実行に要する時間を見積もる事ができる

## 計算量のオーダー記法

**code 2.1 一重のfor文(O(N))**

```cpp
#include <iostream>
using namespace std;

int main() {
  int N;
  cin >> N;

  int count = 0;
  for (int i = 0; i < N; i++)
  {
    ++count;
  }
}
```

計算量は合計 **3N + 2 回** (1~4合計**)** となり、計算量はNに比例していることがわかる。

1. i=0 の代入: 1回
2. i < Nの判定: N + 1回
3. ++i: N回
4. ++count: N回

**code 2.2 二重のfor文(O(N^2))**

```cpp
#include <iostream>
using namespace std;

int main() {
  int N;
  cin >> N;
  int count = 0;
  for (int i = 0; i < N; ++i) {
    for (int j = 0; j < N; j++)
    {
      ++count;
    }
  }
}
```

計算量は++countはN^2回お壊れるため、計算量はN^2に比例していることがわかる。

code2.1の計算量はO(N)、code2.2の計算量はO(N^2)