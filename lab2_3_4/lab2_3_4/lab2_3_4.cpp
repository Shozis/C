// lab2_3_4.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <cmath>
using namespace std;

double Pol(double q)
{
	return abs(q);
}

static double Perimetr(double a, double b, double c)
{
	return a + b + c;
}

double Ploshadi(double d, double a, double b, double c)
{
	return sqrt(d * (d - a) * (d - b) * (d - c));
}

int main()
{
	setlocale(LC_ALL, "Russian");

	// По условию AB = 3, AD = 5, DB = 4, DC = √35, ВС = √19, AC = 5


	cout << "Введите AB:";
	double a1;
	cin >> a1;
	double AB = Pol(a1);

	cout << "Введите AD:";
	double a2;
	cin >> a2;
	double AD = Pol(a2);

	cout << "Введите BD:";
	double a3;
	cin >> a3;
	double BD = Pol(a3);

	cout << "Введите BC:";
	double a4;
	cin >> a4;
	double BC = Pol(a4);

	cout << "Введите AC:";
	double a5;
	cin >> a5;
	double AC = Pol(a5);

	cout << "Введите DC:";
	double a6;
	cin >> a6;
	double DC = Pol(a6);


	double Per1 = Perimetr(AB, BD, AD);
	double Per2 = Perimetr(BC, BD, DC);
	double Per3 = Perimetr(AD, DC, AC);
	double Per4 = Perimetr(AB, BC, AC);



	double S1 = Ploshadi(Per1, AB, BD, AD);
	cout << "Площадь 1 треугольника =";
	cout << S1;

	double S2 = Ploshadi(Per2, BC, BD, DC);
	cout << "Площадь 2 треугольника =";
	cout << S2;

	double S3 = Ploshadi(Per3, AD, DC, AC);
	cout << "Площадь 3 треугольника =";
	cout << S3;

	double S4 = Ploshadi(Per4, AB, BC, AC);
	cout << "Площадь 3 треугольника =";
	cout << S3;

	system("pause");

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
