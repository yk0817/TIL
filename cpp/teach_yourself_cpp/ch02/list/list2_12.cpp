#include <iostream>

decltype(1) one()
{
	return 1;
}

int main()
{
	auto i = one();

	decltype(i) j;
	j = 42.195;
	// warningログ: warning: implicit conversion from 'double' to 'decltype(i)' (aka 'int') changes value from 42.195 to 42
	std::cout << j << std::endl;
}