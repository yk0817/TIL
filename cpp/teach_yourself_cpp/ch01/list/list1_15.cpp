#include <iostream>

int main()
{
	int* ptr = nullptr;

	if (ptr == nullptr)
	{
		std::cout << "ptrはヌルポインタ" << std::endl;
	}
	else
	{
		*ptr = 42;
	}
}