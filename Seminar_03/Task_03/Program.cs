// Задача 3.
// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21


// Координаты №1:
System.Console.WriteLine("Введите координаты X: ");
double A = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите координаты Y: ");
double B = Convert.ToDouble(Console.ReadLine());

// Координаты №2:
System.Console.WriteLine("Введите координаты X: ");
double C = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите координаты Y: ");
double D = Convert.ToDouble(Console.ReadLine());

// Вычисляем расстояние (длину lenght) между двумя точками на плоскости
// X №2 (это переменная С) от -X №1 (это переменная A):
double lengthX = Math.Pow(C-A, 2); // Pow - возведение в квадрат, в скобках через
// запятую указана степень (, 2), в которую необходимо возвести.

// Вычисляем расстояние (длину lenght) между двумя точками на плоскости
// Y №2 (это переменная D) от -Y №1 (это переменная B).
double lengthY = Math.Pow(D-B, 2);

double result = Math.Round(Math.Sqrt(lengthX + lengthY), 2); 
// Вычисление корня квадратного (Sqrt).
// Округление до двух знаков после запятой (Round).
// Допускается применение математических библиотек одновременно. 

System.Console.WriteLine("Расстояние: " + result);
