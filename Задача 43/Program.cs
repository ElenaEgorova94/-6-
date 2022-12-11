﻿//Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//x = (b2 - b1) / (k1 - k2);

//y = (k1 * (b2 - b1)) / (k1 - k2) + b1;



Console.Write("Введите значение b1:  ");
double b1 = double.Parse(Console.ReadLine());

Console.Write("Введите значение k1:  ");
double k1 = double.Parse(Console.ReadLine());

Console.Write("Введите значение b2:  ");
double b2 = double.Parse(Console.ReadLine());

Console.Write("Введите значение k2:  ");
double k2 = double.Parse(Console.ReadLine());

if ((k1 == k2) && (b1 == b2))

{
    Console.WriteLine();
    Console.WriteLine("Прямые совпадают");
}

else if (k1 == k2)

{
    Console.WriteLine();
    Console.WriteLine("Прямые параллельны");
}

else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
    Console.WriteLine();
    Console.WriteLine("Точка пересечения двух заданных прямых: (" + x + ";" + y + ")");
}