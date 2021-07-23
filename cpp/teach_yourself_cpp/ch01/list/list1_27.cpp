#include <iostream>

int main()
{
	int value[] = {-20, 10, 5, -40, 0, 10, -30};
	for (int elem : value)
	{
		if (elem < 0)
		{
			std::cout << "continue:" << elem << std::endl;
			continue;
		}
		if (elem == 0)
		{
			std::cout << "break:" << elem << std::endl;
			break;
		}
		std::cout << "elem = " << elem << std::endl;
	}
	std::cout << "ループ終了" << std::endl;
}