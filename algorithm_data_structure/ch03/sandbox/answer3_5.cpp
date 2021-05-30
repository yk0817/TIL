#include <iostream>
#include <vector>
using namespace std;

int main()
{
  int N, V;
  vector<int> array(N);
  int count = 0;
  int divided_num;

  cout << "配列個数(>=2)を入力してください N=" << endl;
  cin >> N;

  cout << "配列の値(偶数)を入力してください" << endl;
  for (int i = 0; i < N; i++)
  {
    cin >> array[i];
  }

  for (int i = 0; i < N; i++)
  {
    int divided_num = array[i];
    while (divided_num % 2 == 0)
    {
      divided_num /= 2;
      ++count;
    }
  }
  cout << "count:" << count << endl;
}