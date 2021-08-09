#include <iostream>

class product
{
	int id;

public:
	int get_id() const;
	void set_id(int new_id);
};

int product::get_id() const
{
	return id;
}

// setterはメンバー変数の値を変更するのでconstにしない
void product::set_id(int new_id)
{
	id = new_id;
}

int main()
{
	const product cp{};
	std::cout << cp.get_id() << std::endl;
}