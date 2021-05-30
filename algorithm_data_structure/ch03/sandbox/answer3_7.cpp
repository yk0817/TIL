#include <iostream>
using namespace std;

int main()
{
  
  // 
  // 1. 数字でのループ件数を取得
  // 2. +を入れるかどうか
  // 3. +を入れたら計算する
  string S;
  int N, tmp;
  int total_amount = 0;

  cout << "正の整数を入力してください: S=" << endl;
  cin >> S;
  cout << S << endl;
  N = S.size();
  cout << "Nの文字列数は" << N << endl;
  for (int i = 0; i < N; i++)
  {
    cout << "+をつけますか？" << S[i] << endl;
    cin >> tmp;
    if (tmp == "+")
    {
      /* code */
    }
    
  }
  
}