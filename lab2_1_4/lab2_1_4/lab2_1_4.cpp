﻿// lab2_1_4.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <cmath>
using namespace std;

double Perimetr(double x, double y)
{
	return x * y;
}


int main()
{
    setlocale(LC_ALL, "Russian");

	cout << "Введите n1:";
	double n1;
	cin >> n1;
	double a1 = storona(n1);
	cout << a1 << endl;
	cout << "Периметр 1 треугольника =:";
	double Per1 = Perimetr(n1, a1);


	cout << "Введите n2:";
	double n2;
	cin >> n2;
	double a2 = storona(n2);
	cout << a2 << endl;
	cout << "Периметр 2 треугольника =:";
	double Per2 = Perimetr(n2, a2);

	cout << "Введите n3:";
	double n3;
	cin >> n3;
	double a3 = storona(n3);
	cout << a3 << endl;
	cout << "Периметр 3 треугольника =:";
	double Per3 = Perimetr(n3, a3);


	system("pause");
}

double storona(double q)
{
	double R = 15;
	return 2 * R * sin(180 / q);
}
// Запуск программы: CTRL+F5 или меню "Отладка" > "Запуск без отладки"
// Отладка программы: F5 или меню "Отладка" > "Запустить отладку"

// Советы по началу работы 
//   1. В окне обозревателя решений можно добавлять файлы и управлять ими.
//   2. В окне Team Explorer можно подключиться к системе управления версиями.
//   3. В окне "Выходные данные" можно просматривать выходные данные сборки и другие сообщения.
//   4. В окне "Список ошибок" можно просматривать ошибки.
//   5. Последовательно выберите пункты меню "Проект" > "Добавить новый элемент", чтобы создать файлы кода, или "Проект" > "Добавить существующий элемент", чтобы добавить в проект существующие файлы кода.
//   6. Чтобы снова открыть этот проект позже, выберите пункты меню "Файл" > "Открыть" > "Проект" и выберите SLN-файл.