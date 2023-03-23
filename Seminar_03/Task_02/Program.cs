// Задача 2.
// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных 
// координат точек в этой четверти (x и y).

System.Console.WriteLine("Введите число четверти: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Результат: ");
if (a == 1)
{
    System.Console.WriteLine("x > 0, y > 0");
}
else if (a == 2)
{
    System.Console.WriteLine("x < 0, y > 0");
}
else if (a == 3)
{
    System.Console.WriteLine("x < 0, y < 0");
}
else if (a == 4)
{
    System.Console.WriteLine("x > 0, y < 0");
}
else
{
    System.Console.WriteLine("Неправильный ввод");
}
