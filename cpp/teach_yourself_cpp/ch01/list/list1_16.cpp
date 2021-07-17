#include <iostream>

int main()
{
	float f = -1234.5678f;
	std::cout << f << std::endl;

	// floatからintへの暗黙の型変換
	int i = f;

	std::cout << i << std::endl;

	// intからunsigned intへの暗黙の型変換
	unsigned int u = i;

	std::cout << u << std::endl;

	// unsigned intからunsigned shortへの暗黙の型変換
	unsigned short s = u;

	std::cout << s << std::endl;

	u = s;
	std::cout << u << std::endl;

	f = u;
	std:: cout << f << std::endl;
}