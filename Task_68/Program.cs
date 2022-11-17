int Akkerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else if (m == 0)
        return Akkerman(n - 1, 1);
    else return Akkerman(n - 1, Akkerman(n, m - 1));
}
Console.Clear();
Console.Write("Введите два неотрицательных числа: ");
string[] num = Console.ReadLine()!.Split(' ');
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
while (n < 0 || m < 0)
{
    Console.WriteLine("Введите два неотрицательных числа: ");
    num = Console.ReadLine()!.Split(' ');
    n = int.Parse(num[0]);
    m = int.Parse(num[1]);
}
Console.WriteLine(Akkerman(n, m));