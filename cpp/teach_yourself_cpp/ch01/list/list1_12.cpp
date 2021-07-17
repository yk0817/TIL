#include <iostream>

void nochange(int i)
{
	i = 42;
}

void set42(int* pi)
{
	// 仮引数で渡されたアドレスが指し示す変数に42を代入する
	*pi = 42;
}

int main()
{
	int i = 0;

	nochange(i);
	// 変数i自体は変更されない
	std::cout << i << std::endl;

	// 変数iのアドレスに42を代入
	set42(&i);

	// set42がアドレスを使って変数iを変更しているのでiの値は42になっている。
	std::cout << i << std::endl;
}