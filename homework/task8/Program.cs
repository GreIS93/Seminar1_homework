// Выяснить, кратно ли число заданному, если нет, вывести остаток
Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());
if (a % b == 0) 
{
    Console.Write("Число " + a + " кратно числу " + b);
}
else 
{
    Console.Write("Остаток от деления " + (a % b));
}
