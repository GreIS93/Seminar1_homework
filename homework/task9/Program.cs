// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
if (n < 100)
{
    Console.WriteLine("В числе нет третьей цифры");
}
else 
{
    int NumberIndex = 2;
    string temp = n.ToString();
    char ch = temp [NumberIndex];
    Console.WriteLine(ch);
}