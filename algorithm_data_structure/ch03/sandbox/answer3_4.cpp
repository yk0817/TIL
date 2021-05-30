#include <iostream>
#include <vector>
using namespace std;

int main()
{
  int N, V;
  vector<int> array(N);
  int START_LARGE_NUM = -10000;
  int START_MIN_NUM = 10000;

  cout << "配列個数(>=2)を入力してください N=" << endl;
  cin >> N;

  cout << "配列の値を入力してください" << endl;
  for (int i = 0; i < N; i++)
  {
    cin >> array[i];
  }

  for (int i = 0; i < N; i++)
  {
    if (array[i] > START_LARGE_NUM) {
      START_LARGE_NUM = array[i];
    }
    if (array[i] < START_MIN_NUM) {
      START_MIN_NUM = array[i];
    }
  }
  cout << "最大の差は" << START_LARGE_NUM - START_MIN_NUM << endl;
}