#include <iostream>

void show_value(float f)
{
	std::cout << f << std::endl;
}

int main()
{
	// 問題文はintだったのでcastされていた
	float i = 42.195f;
	show_value(i);
}