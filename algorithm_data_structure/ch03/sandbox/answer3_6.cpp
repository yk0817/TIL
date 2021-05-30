#include <iostream>
using namespace std;

int main(){
  int K, N;
  int count = 0;
  cout << "正の整数を入力してください: K=" << endl;
  cin >> K;

  cout << "正の整数を入力してください: N=" << endl;
  cin >> N;

  for (int x = 0; x < K; x++)
  {
    for (int y = 0; y < K; y++)
    {
      int z = N - x - y;
      if (K >= z)
      {
        count++;
      }
    }
  }
  cout << "count:" << count << endl;
}