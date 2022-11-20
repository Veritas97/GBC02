Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

bool Resultat(int number1)
{
    if (number1 % 7 == 0) 
    if (number1 % 23 == 0) 
    return true;
    return false;
}

bool resul = Resultat(num1);
Console.Write(resul ? $"Число {num1} кратно 7 и 23" : $"Число {num1} не кратно 7 и 23");