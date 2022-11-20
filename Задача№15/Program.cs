Console.Write("Введите число дня недели: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 == 1) Console.WriteLine("Ваш день: Понедельник");
if (num1 == 1) Console.WriteLine("Данный день рабочий");
else if (num1 == 2) Console.WriteLine("Ваш день: Вторник");
if (num1 == 2) Console.WriteLine("Данный день рабочий");
else if (num1 == 3) Console.WriteLine("Ваш день: Среда");
if (num1 == 3) Console.WriteLine("Данный день рабочий");
else if (num1 == 4) Console.WriteLine("Ваш день: Четверг");
if (num1 == 4) Console.WriteLine("Данный день рабочий");
else if (num1 == 5) Console.WriteLine("Ваш день: Пятница");
if (num1 == 5) Console.WriteLine("Данный день рабочий");
else if (num1 == 6) Console.WriteLine("Ваш день: Суббота");
if (num1 == 6) Console.WriteLine("Данный день выходной");
else if (num1 == 7) Console.WriteLine("Ваш день: Воскресенье");
if (num1 == 7) Console.WriteLine("Данный день выходной");
else if (num1 >= 8) Console.Write("Такого дня не существует");

