// Обсуждение домашнего задания к Семинару №1:

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли
// число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// По данной задаче предложений нет.

int Prompt(string message)
{
    System.Console.Write(message);
    string strValue;
    strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

int A = Prompt("Введите число для проверки > ");

if(A % 2 == 0)
{
    Console.WriteLine("Введенное число четное");
}

else
{
    Console.WriteLine("Введенное число нечетное");
}