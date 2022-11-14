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
void FindMin(int[,] matrix,int[]array)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = matrix[i,j] + sum; 
        }
        array[i] = sum;
        sum = 0;
    }
    int min = array [0]; int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array [i] < min)
        {
           array[i] = min ;
           index = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов в строке: {index + 1}");
}
Console.Clear();
Console.Write("Введите кол-во строк и столбцов: ");
string[] num = Console.ReadLine()!.Split(' ');
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
int[,] matrix = new int[n, m];
int[] array = new int[n];
Console.WriteLine("Начальный массив: ");
InputMatrix(matrix);
FindMin(matrix,array);