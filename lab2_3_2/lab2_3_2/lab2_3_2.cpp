// lab2_3_2.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <cmath>
using namespace std;

int main()
{
    
	int x = -3;
	int b = 6;
	int c = -4;

	int h;

	if (0 < x && x < 1) {

		h = b * x + 1;
	}
	else if (x <= 0) {

		int minEl = pow(x, 3);
		if (minEl < sqrt(abs(b * x))) {
			minEl = sqrt(abs(b * x));
		}

		if (minEl < x + b) {
			minEl = x + b;
		}

		h = minEl;
	}
	else {

		int maxEl = cos(b * x);
		if (maxEl > x + c) {
			maxEl = x + c;
		}
	}

	cout << h << endl;
}

