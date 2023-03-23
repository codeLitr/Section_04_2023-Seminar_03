// Обсуждение домашнего задания к Семинару №1:

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе
// показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int Prompt(string message)
{
    System.Console.Write(message);
    string strValue;
    strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int value = Prompt("Введите число > ");

// Чтобы убрать вывод запятой после последнего числа, необходимо добавить в мой код 
// следующее:
Console.Write($"{value} -> ");
for (int index = 2; index <= value; index += 2)
{
    if (index == value) //Добавлено.
    {
        System.Console.Write(index + ""); //Добавлено. Здесь можно указать любой 
        // символ, который будет стоять после последней цифры, например ";".
    }
    else //Добавлено.
    {
        System.Console.Write(index + ", "); //Добавлено.
    }
   // Console.Write($"{index},"); //Убрано, т.к. добавлен вывод.
}