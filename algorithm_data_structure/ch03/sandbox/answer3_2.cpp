#include <iostream>
#include <vector>
using namespace std;

int main() {
  int N, V;
  vector<int> a(N);

  cout << "配列個数を入力してください N=" << endl;
  cin >> N;
  cout << "整数値を入力してください V=" << endl;
  cin >> V;

  cout << "配列の値を入力してください" << endl;
  for (int i = 0; i < N; i++)
  {
    cin >> a[i];
  }

  int counter = 0;

  for (int i = 0; i < N; i++)
  {
    if (a[i] == V)
    {
      ++counter;
    }
  }
  cout << "配列の中にVが含まれている個数は" << endl;
  cout << counter << endl;
}