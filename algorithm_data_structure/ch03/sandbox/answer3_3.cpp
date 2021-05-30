#include <iostream>
#include <vector>
using namespace std;

int main()
{
  int N, V;
  vector<int> array(N);
  int START_NUM = 9999999;

  int FIRST_SMALL_NUM = START_NUM;
  int SECOND_SMALL_NUM = START_NUM;

  cout << "配列個数(>=2)を入力してください N=" << endl;
  cin >> N;

  cout << "配列の値を入力してください" << endl;
  for (int i = 0; i < N; i++)
  {
    cin >> array[i];
  }

  for (int i = 0; i < N; i++)
  {
    if (array[i] < FIRST_SMALL_NUM)
    {
      SECOND_SMALL_NUM = FIRST_SMALL_NUM;
      FIRST_SMALL_NUM = array[i];
    }
    else if (array[i] < SECOND_SMALL_NUM)
    {
      SECOND_SMALL_NUM = array[i];
    }
  }
  cout << "2番目に小さい値は" << SECOND_SMALL_NUM << endl;
}