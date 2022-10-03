// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 1)
{
    int counter = 1;
    while (counter <= number)
    {
        if (counter % 2 == 0)
        {
            Console.Write($"{counter}, ");
        }
        counter++;
    }
}
else Console.Write($"Задан некорректный числовой интервал (от 1 до {number})");
