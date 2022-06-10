// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] array54 = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};


int[,] ArrayOrderMaxMin(int[,] array)
{
    int[,] arrayMaxMin = new int[array.GetLength(0), array.GetLength(1)];
    
    int a1 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int b1 = 0; b1 < array.GetLength(1); b1++)
        {
            int max = array[i, 0];
            int jMax = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] > max) 
                {
                    max = array[i, j];
                    jMax = j;
                }
            }
            arrayMaxMin[a1, b1] = max;
            array[i, jMax] = 0;
        }
        a1++;
    }
    return arrayMaxMin;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " "); 
        }
        Console.WriteLine();
    }
}

int[,] arrayRes = ArrayOrderMaxMin(array54);
PrintArray(arrayRes);