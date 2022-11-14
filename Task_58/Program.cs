void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void Multiply(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    {
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                result[i, j] = matrix1[i, j] * matrix2[i, j];
                Console.Write($"{result[i, j]} \t");
            }
            Console.WriteLine();
        }
    }
}
Console.Clear();
Console.Write("Введите кол-во строк и столбцов: ");
string[] num = Console.ReadLine()!.Split(' ');
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
int[,] matrix1 = new int[n, m];
int[,] matrix2 = new int[n, m];
Console.WriteLine("Первая матрица: ");
InputMatrix(matrix1);
Console.WriteLine("Вторая матрица: ");
InputMatrix(matrix2);
Console.WriteLine("Результаат умножения: ");
Multiply(matrix1, matrix2);