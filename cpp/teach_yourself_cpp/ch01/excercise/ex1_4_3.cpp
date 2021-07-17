#include <iostream>

int main()
{
	int a = 2;

	if (a+1 == 1)
	{
		std::cout << "a + 1 は1です" << std::endl;
	}
	else if (a+1 == 2)
	{
		std::cout << "a + 1 は2です" << std::endl;
	}
	else
	{
		std::cout << "a+1は1でも、2でもありません。" << std::endl;
	}
}