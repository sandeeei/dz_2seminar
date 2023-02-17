// Задача 13: Напишите программу, которая выводит третью цифру
//  заданного семизначного числа или сообщает, что третьей цифры нет.

// 78 -> третьей цифры нет

// 3267900 -> 6
//ДОП: цифра третья может быть как с левой стороны, так и с правой
// Но ведь в трехзначном числе и иже с ним третья цифра есть

 Console.Write("Введите семизначьное число: ");
 int number = Convert.ToInt32(Console.ReadLine());
if(number<0) number=number*-1;
 if (number>=1000000 && number<10000000)
{
   int result= number%100000/10000;
   int result1 = number%1000/100;
   Console.WriteLine($"В числе : {number} третьей цифрой слева является {result} , а третьей цифрой справа является {result1} ");
   return;
}
else
{
    if (number<100)
    {
        Console.WriteLine($"Третьей цифры в числе:  {number} нет");
    }
    Console.WriteLine("Число:  " + number + " не семизначное");
    return;
}