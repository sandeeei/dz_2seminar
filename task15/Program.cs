// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число от 1 до 7 : ");
int number = Convert.ToInt32(Console.ReadLine());

if (number>=1 && number<=7)
{
    if (number==7 || number == 6)
    {
        Console.WriteLine($"Число:  {number}  выходной день");
    }
    else
    {
        Console.WriteLine($"Число:  {number}  будний день");
        return;
    }
}
else
{
    Console.WriteLine($"Число:  {number}  не попадает в диапазон от 1 до 7");
}
