#include <iostream>

struct S
{
	int a;
	int b;
	int c;
};

int main()
{
	S s;
	std::cout << "s.aのアドレスは" << &s.a << std::endl;
	std::cout << "s.bのアドレスは" << &s.b << std::endl;
	std::cout << "s.cのアドレスは" << &s.c << std::endl;
}