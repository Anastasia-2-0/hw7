// x

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());

int[,] table = FillArray(rows, columns);

PrintArray(table);

for (int j = 0; j < table.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < table.GetLength(0); i++)
    {
        avarage = (avarage + table[i, j]);
    }
    avarage = avarage / rows;
    Console.Write(Math.Round(avarage,3) + "; ");
}
Console.WriteLine();

int[,] FillArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
