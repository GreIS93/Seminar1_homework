// Выяснить является ли число чётным
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
int i = 0;
int n1 = n;
if (n % 2 == 0) 
{
    Console.Write("Число " + n + " является четным");
}
else 
{
    Console.Write("Число " + n + " является нечетным");
}