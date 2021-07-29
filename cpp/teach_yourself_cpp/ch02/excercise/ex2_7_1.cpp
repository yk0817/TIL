#include <iostream>

int sum(int a, int b, int c, int d)
{
	return a + b + c + d;
}

int main()
{
	int total = sum(1, 2, 3, 4);
	std::cout << total << std::endl;
}