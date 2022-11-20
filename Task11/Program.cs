int num1 = new Random().Next(100, 1000);
Console.WriteLine($"Наше рандомное трехзначное число : {num1}");

int removeNum2(int num)
{
    int num2 = num1 / 100;
    int num3 = num1 % 10;
    int result = num2 * 10 + num3;
    return result;
}


Console.WriteLine(removeNum2(num1));