#include <iostream>

struct U
{
	int a;
	int b;
	int c;
};

int main()
{
	U u;
	std::cout << "u.aのアドレスは" << &u.a << std::endl;
	std::cout << "u.bのアドレスは" << &u.b << std::endl;
	std::cout << "u.cのアドレスは" << &u.c << std::endl;
}