Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool Resultat(int number1, int number2)
{
    return (number1 * number1 == number2) || (number2 * number2 == number1);
}

bool resul = Resultat(num1, num2);
Console.Write(resul ? $"Число {num1} яляется квадратом числа {num2}" : $"Число {num1} не является квадратом числа {num2}");