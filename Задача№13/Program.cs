// Задача 13: 
// Напишите программу, 
// 1)заданного числа или сообщает,  
// 2)которая выводит третью цифру 
// 3)что третьей цифры нет.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 <= 99) Console.Write($"В числе {num1} нет третий цифры");

else
{
while (num1 >= 999)
    {
    num1 = num1 / 10;
    // Console.WriteLine(num1); введенно для проверки кода
    }
num1 = num1 % 10;
Console.WriteLine($"Третья цифра: {num1}");
}