Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool Resultat(int number1, int number2)
{
    if (number1 % number2 == 0) return true;
    return false;
}

bool resul = Resultat(num1, num2);
Console.Write(resul ? "Кратно" : $"Некратно, остаток = {num1%num2}");