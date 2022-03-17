// Является ли первое число квадратом второго
Console.WriteLine("Введите число a:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b:");
int b = int.Parse(Console.ReadLine());

if (a == b*b)
{
    Console.WriteLine("Число " + a + " является квадратом числа " + b);
}
else 
{
    Console.WriteLine("Число " + a + " не является квадратом числа " + b);
}