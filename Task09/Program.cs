// Задача №9
// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int num1 = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 --> {num1}");

// int num2 = num1 / 10;
// int num3 = num1 % 10;

// if (num2 > num3) Console.Write($"Наибольшая цифра числа: {num2}");
// else Console.Write($"Наибольшая цифра числа: {num3}");


int MaxNum(int num)
{
    int num2 = num1 / 10;
    int num3 = num1 % 10;
    if (num2 > num3) return num2;
    return num3;
}

int maxnum = MaxNum(num1);
Console.Write($"Наибольшая цифра числа: {maxnum}");