// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int num = new Random().Next(10, 99);
Console.WriteLine("Дано число: " + num);

if ((num / 10) > (num % 10))
{
    Console.WriteLine("Наибольшая цифра в числе: " + num / 10);
}
else
{
    Console.WriteLine("Наибольшая цифра в числе: " + num % 10);
}
