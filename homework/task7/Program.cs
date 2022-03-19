// Удалить вторую цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());
string temp = num.ToString();
temp = temp.Remove(1, 1);
int result = Convert.ToInt32(temp);
Console.WriteLine(temp);