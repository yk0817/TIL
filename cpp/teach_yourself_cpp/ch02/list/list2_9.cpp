#include <iostream>

int main()
{
	int value = 42;
	int other = 0;

	int* pointer = &value;
	int& reference = value;

	std::cout << "valueのアドレスは" << &value << "で、値は" << value << "です" << std::endl;
	std::cout << "otherのアドレスは" << &other << "で、値は" << other << "です" << std::endl;
	std::cout << "pointerのアドレスは" << &pointer << "で、値は" << *pointer << "です" << std::endl;
	std::cout << "referenceのアドレスは" << &reference << "で、値は" << reference << "です" << std::endl;

	pointer = &other;
	reference = other;

	std::cout << std::endl;

	std::cout << "valueのアドレスは" << &value << "で、値は" << value << "です" << std::endl;
	std::cout << "otherのアドレスは" << &other << "で、値は" << other << "です" << std::endl;
	// pointerのアドレスは変更
	std::cout << "pointerのアドレスは" << &pointer << "で、値は" << *pointer << "です" << std::endl;
	// referenceは初期の設定のアドレスを示す。
	std::cout << "referenceのアドレスは" << &reference << "で、値は" << reference << "です" << std::endl;
}