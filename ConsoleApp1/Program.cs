// See https://aka.ms/new-console-template for more information
Console.Write("Введите номер текущего месяца ");
int mes = Convert.ToInt32(Console.ReadLine());
switch (mes)
{
    case 0:Console.WriteLine("Нет такого месяца"); break;
    case 1:Console.WriteLine("Зима"); break;
    case 2: Console.WriteLine("Зима"); break;
    case 3: Console.WriteLine("Весна"); break;
    case 4: Console.WriteLine("Весна"); break;
    case 5: Console.WriteLine("Весна"); break;
    case 6: Console.WriteLine("Лето"); break;
    case 7: Console.WriteLine("Лето"); break;
    case 8: Console.WriteLine("Лето"); break;
    case 9: Console.WriteLine("Осень"); break;
    case 10: Console.WriteLine("Осень"); break;
    case 11: Console.WriteLine("Осень"); break;
    case 12: Console.WriteLine("Зима"); break;
}
if (mes > 12) Console.WriteLine("Ошибка!");
