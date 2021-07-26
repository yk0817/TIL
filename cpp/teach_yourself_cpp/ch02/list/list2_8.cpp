#include <iostream>

int main()
{
	int value = 42;

	std::cout << "valueのアドレスは" << &value << "で、値は" << value << "です" << std::endl;

	int& reference = value;

	std::cout << "referenceのアドレスは" << &reference << "で、値は" << reference << "です" << std::endl;

	// valueとreferenceはアドレスが同一なので、書き換えると値が変更される
	reference = 0;
	std::cout << "valueのアドレスは" << &value << "で、値は" << value << "です" << std::endl;
}