#include <iostream>

void show_messages()
{
	std::cout << "hello, world" << std::endl;
	return;
	// returnがあったので↓は実行されず。
	std::cout << "hello, return" << std::endl;
}

int main(){
	show_messages();
}