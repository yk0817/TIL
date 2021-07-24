#include <iostream>

class product
{
	int id;
	int price;
	int stock;

public:
	int get_id();
	int get_price();
	int get_stock();
	void set(int new_id, int new_price, int new_stock);
};

int product::get_id()
{
	return id;
}


int product::get_price()
{
	return price;
}

int product::get_stock()
{
	return stock;
}

void product::set(int new_id, int new_price, int new_stock)
{
	id = new_id;
	price = new_price;
	stock = new_stock;
}

		int main()
{
	product pen;

	pen.set(0, 100, 200);

	product *ptr = &pen;

	std::cout << "商品ID:" << ptr->get_id() << std::endl;
	std::cout << "単価:" << ptr->get_price() << std::endl;
	std::cout << "在庫数:" << ptr->get_stock() << std::endl;
}