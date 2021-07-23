#include <iostream>

int main()
{
	int value[] = {-20, 10, 5, -40, 0, 10, -30};
	int i = 0;

	do
	{
		if (value[i] < 0)
		{
			std::cout << "continue:" << value[i] << std::endl;
			++i;
			continue;
		}
		if (value[i] == 0)
		{
			std::cout << "break:" << value[i] << std::endl;
			break;
		}
		std::cout << "elem = " << value[i] << std::endl;
		++i;
	} while(i < 7);

	std::cout << "ループ終了" << std::endl;
}