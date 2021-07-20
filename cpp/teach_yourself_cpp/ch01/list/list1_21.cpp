#include <iostream>

int main()
{
	int array[10] = {};

	// 型が変更されても要素の型も同じく変更される
	std::size_t length = sizeof(array) / sizeof(array[0]);

	std::cout << "array[" << length << "]" << std::endl;
}