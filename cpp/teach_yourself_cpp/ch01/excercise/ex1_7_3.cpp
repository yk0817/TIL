#include <iostream>

int main()
{
	int array[] = {4, 2, 1, 9, 5};
	int i = 4;

	do
	{
		std::cout << array[i] << std::endl;
		--i;
	} while (i > -1);
}
