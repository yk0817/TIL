#include <iostream>

int main()
{
	int a = 0;
	auto lambda = [a]()
	{
		std::cout << a << std::endl;
	};

	lambda();
	a = 42;

	// キャプチャした段階で変数は変わらない
	lambda();
}