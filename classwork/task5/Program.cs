// Показать последнюю цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число");
int n = int.Parse(Console.ReadLine());

if (100 <= n && n <= 1000)
{
    Console.WriteLine(n % 10);
}
else
{
    Console.WriteLine("Введите число из 3 знаков");
}