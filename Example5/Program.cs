// Напишите консольную программу, которая выводит пользователю сообщение "Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение".
//  Рядом с названием каждой операции указан ее номер, например, операция вычитания имеет номер
//  2. Пусть пользователь вводит в программу номер операции, и в зависимости от номера операции программа выводит ему название операции.

Console.WriteLine("Введите номер операции: ");
int operation = Convert.ToInt32(Console.ReadLine());
switch(operation)
{
    case 1:
    Console.WriteLine("Сложение");
    break;



    case 2:
    Console.WriteLine("Вычитание");
    break;


    case 3:
    Console.WriteLine("Умножение");
    break;
}