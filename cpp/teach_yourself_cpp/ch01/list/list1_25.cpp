#include <iostream>

int main()
{
	int value[] = {-20, 10, 5, -40, 0, 10, -30};

	int i = 0;

	while (i < 8)
	{
		if (value[i] < 0)
		{
			std::cout << "continue:" << value[i] << std::endl;
			++i;
			continue; // loop終わり。条件式に飛ぶ
		}
		if (value[i] == 0)
		{
			std::cout << "break:" << value[i] << std::endl;
			break; // loop抜ける
		}
		
		std::cout << "elem = " << value[i] << std::endl;
		++i;
	}
	
	std::cout << "ループの終了" << std::endl;
}