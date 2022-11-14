void Input3DMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(10, 100);
                Console.Write($"{matrix[i, j, k]}{(i, j, k)} \t");
            }
            Console.WriteLine();
        }
    }
}
Console.Clear();
Console.Write("Введите три координаты: ");
string[] num = Console.ReadLine()!.Split(new Char[] { ' ' });
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
int k = int.Parse(num[2]);
int[, ,] matrix = new int[n, m, k];
Input3DMatrix(matrix);
