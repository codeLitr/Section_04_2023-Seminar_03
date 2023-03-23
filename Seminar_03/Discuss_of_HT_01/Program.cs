// Обсуждение домашнего задания к Семинару №1:

// Задача 2:
// Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше.
// a = 5;	b = 7 -> max 7
// a = 2;	b = 10 -> max 10
// a = -9;	b = -3 -> max -3
int Prompt(string message)
{
    System.Console.Write(message);
    string strValue;
    strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int firstNumb = Prompt("Введите первое число > ");
int secondNumb = Prompt("Введите второе число > ");

// Предложение преподавателя сделать через библиотеку Math и выбрать подраздел Max -
// это позволит выбрать из двух чисел наибольшее (мой вариант решения закомментирован):

// if (firstNumb > secondNumb)
// {
// 	Console.Write("Наибольшее число -> ");
//     Console.WriteLine(firstNumb);
//     Console.Write("Наименьшее число -> ");
//     Console.Write(secondNumb);
// }
// else
// {
//     Console.Write("Наименьшее число -> ");
//     Console.WriteLine(firstNumb);
//     Console.Write("Наибольшее число -> ");
//     Console.Write(secondNumb);
// }

int max = Math.Max(firstNumb, secondNumb);
System.Console.WriteLine($"Наибольшее число -> {max}");

int min = Math.Min(firstNumb, secondNumb);
System.Console.WriteLine($"Наименьшее число -> {min}");
