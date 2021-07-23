#include <iostream>

// この段階ではテンプレートパラメータのTは具体的な型が決まっていない
template <typename T>

T fused_multiply_add(T a, T b, T c)
{
	T r = a * b + c;
	return r;
}

int main()
{
	std::cout << fused_multiply_add<int>(1, 2, 3) << std::endl;
	std::cout << fused_multiply_add<float>(1.23456f, 1.23456f, 1.23456f) << std::endl;
	std::cout << fused_multiply_add<double>(1.23456, 1.23456f, 1.23456) << std::endl;
}