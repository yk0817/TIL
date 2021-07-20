#include <iostream>

int main()
{
	std::string string = "string \0 string";
	// null文字までがstring
	std::cout << string << std::endl;
}