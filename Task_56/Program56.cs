// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] array56 = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};

int[] SummRow(int[,] array)
{
    int length = array.GetLength(0);
    int[] summRows = new int[length];
    int rowLength = array.GetLength(1);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int a = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            a = a + array[i, j];
        }
        summRows[i] = a;
    }
    return summRows;
}

int MaxFromArray(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

void PrintPlace(int num, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) Console.WriteLine(i + 1);
    }
}


int[] summRow = SummRow(array56);
int max56 = MaxFromArray(summRow);
Console.Write("Строка с наибольшей суммой элементов ");
PrintPlace(max56, summRow);
