#include <iostream>

int main()
{
	auto show_variable = [](int v) -> void
	{
		std::cout << v << std::endl;
	};
	show_variable(10);
}