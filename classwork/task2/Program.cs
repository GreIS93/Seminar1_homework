// Сравнить 2 числа
Console.WriteLine("Введите число a:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b:");
int b = int.Parse(Console.ReadLine());

if (a == b)
{
    Console.WriteLine("Число " + a + " равно числу " + b);
}
else if (a>b)
    {
        Console.WriteLine("Число " + a + " больше числа " + b);
    }
    else 
    {
        Console.WriteLine("Число " + a + " меньше числа " + b);
    }