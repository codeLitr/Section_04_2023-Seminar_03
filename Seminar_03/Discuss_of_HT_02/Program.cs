// Обсуждение домашнего задания к Семинару №1:

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт 
//максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int Prompt(string message)
{
    System.Console.Write(message);
    string strValue;
    strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int A = Prompt("Введите первое число > ");
int B = Prompt("Введите второе число > ");
int C = Prompt("Введите третье число > ");

// Предложение преподавателя сделать через библиотеку Math и выбрать подраздел Max -
// это позволит выбрать из трех чисел наибольшее (мой вариант решения закомментирован):

// int max = A;

// if (A > max) max = A;
// if (B > max) max = B;
// if (C > max) max = C;

// Console.Write("max = ");
// Console.Write(max);

int maxOfTwo = Math.Max(A, B);
int maxOfThree = Math.Max(maxOfTwo, C);

Console.Write("Максимальное число: " + maxOfThree);
