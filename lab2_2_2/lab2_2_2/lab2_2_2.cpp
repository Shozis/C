﻿// lab2_2_2.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <cmath>
using namespace std;

int main()
{

	int x = 3;
	int a = 5;
	int b = -2;

	int f;

	if (0 < x && x <= 1) {

		int minEl = (x - a) / x;
		if (minEl < sqrt(a) + x) {
			minEl = sqrt(a);

		}

		if (minEl < sin(x)) {
			minEl = sin(x);
		}

		f = sin(x);
	}
	else if (x > 1) {

		int maxEl = a * x;
		if (maxEl > sqrt(x)) {
			maxEl = sqrt(x);
		}

		f = maxEl;
	}
	else if (x <= 0) {

		f = a * x + b;
	}

	cout << f << endl;
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
