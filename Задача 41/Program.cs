// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Сколько чисел Вы хотите ввести?");
int m = int.Parse(Console.ReadLine());
int res = 0;
Console.WriteLine("Вводите числа: ");

for (int i = 0; i < m; i++)
{
    if (int.Parse(Console.ReadLine()) > 0)
        {
        res++;
        }
}


Console.WriteLine("Ваши числа, которые больше 0: " + res);