int FindSum(int n, int m)
{
    if (n == m)
        return n;
    return FindSum(n, m - 1) + m;
}
Console.Clear();
Console.Write("Введите двачисла: ");
string[] num = Console.ReadLine()!.Split(' ');
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
if (n > m)
{
    int temp = 0;
    temp = n; n = m; m = temp;
}
Console.WriteLine($"Сумма равна: {FindSum(n, m)}");
