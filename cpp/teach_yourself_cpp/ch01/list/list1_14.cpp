#include <iostream>

int main()
{
	int* ptr = nullptr;

	*ptr = 42;

	std::cout << "ヌル参照のあと" << std::endl;
}