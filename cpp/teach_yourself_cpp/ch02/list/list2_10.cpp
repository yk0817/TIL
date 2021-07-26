#include <iostream>

int one()
{
	return 1;
}

int main()
{
	auto d = 3.14;

	d = 2.71f;

	std::cout << d << std::endl;

	auto i = one();

	// int→doubleへの暗黙の型変換
	// 実行すると↓のログが出る
	// warning: implicit conversion from 'double' to 'int' changes value from 42.195 to 42
	i = 42.195;

	std::cout << i << std::endl;
}