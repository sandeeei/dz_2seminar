// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

 Console.Write("Введите трёхзначное число: ");
 int number = Convert.ToInt32(Console.ReadLine());
if(number<0) number=number*-1;
// if (number>999 || number<100)
// {
//     Console.Write($"Число:  {number} не является трёхзначным числом ");
//     return;
// }

// int result = number%100/10;

// Console.WriteLine($"Вторая цифра в числе {number} :  {result}");

while(number>999 || number<100)
{
    Console.Write($"Число:  {number} не является трёхзначным числом, Введите ТРЁХЗНАЧНОЕ число:   ");
    number = Convert.ToInt32(Console.ReadLine());
}
int result = number%100/10;

Console.WriteLine($"Вторая цифра в числе {number} :  {result}");

// работает))