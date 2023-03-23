// Задача 4.
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов 
// чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

System.Console.WriteLine("Введите число: ");
int numb = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Таблица квадратов для числа {numb}:");

for (int i = 1; i <= numb; i++)
{
    int tableSqrt = (int)Math.Pow(i, 2); // Т.к. Math.Pow всегда возвращает тип данных
    // double, то его необходимо конвертировать в int "(int)".
    System.Console.WriteLine($"{i} * {i} = {tableSqrt}");
}
