// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
//столбцы
// ст 1 4 7 2
// ро 5 9 2 3
// ки 8 4 2 4
//[1,7] -> такого числа в массиве нет ([1,7] это позиция элемента)

Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());

int[,] table = FillArray(rows, columns);

PrintArray(table);

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
Console.WriteLine("Введите позицию в столбце: ");
int columnsPosition = int.Parse(Console.ReadLine());
Console.WriteLine("Введите позицию в строке: ");
int rowsPosition = int.Parse(Console.ReadLine());

if (rowsPosition < table.GetLength(0) && columnsPosition < table.GetLength(1))
{
    Console.WriteLine($"число с данной позицией равно {table[rowsPosition, columnsPosition]}");
}
else
{
    Console.WriteLine($"{rowsPosition};{columnsPosition} -> такого числа в массиве нет");
}
