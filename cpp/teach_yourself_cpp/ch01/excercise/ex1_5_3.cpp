#include <iostream>

int main()
{
	int i = 0;
	int* point = &i;
	*point = 42;
	std::cout << i << std::endl;
}