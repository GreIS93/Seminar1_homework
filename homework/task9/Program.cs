// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
int res = 0;
while(n != 0)
            {
                res = n % 10;
                n /= 10;
            }
