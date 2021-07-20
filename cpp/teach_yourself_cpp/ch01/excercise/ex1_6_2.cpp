#include <iostream>

int main()
{
	char string[] = "string \0 string";
	// null文字までがstring
	std::cout << string << std::endl;
}