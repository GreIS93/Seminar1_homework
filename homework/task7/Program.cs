// Удалить вторую цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());
int numDelet(int n)
{
    string buf = num.ToString();
    buf = buf.Remove(n - 1, 2);
    int result = Convert.ToInt32(buf);
    return result;
}