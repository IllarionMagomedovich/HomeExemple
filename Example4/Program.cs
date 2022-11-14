// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");

int numb = Convert.ToInt32(Console.ReadLine());
int index = 0;

while(index <= numb)
{
    Console.WriteLine(index);
    index = index + 2;
}
