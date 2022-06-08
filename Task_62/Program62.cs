// Задача 62: Заполните спирально массив 4 на 4.

// По условию задачи она должна решаться для массива 4*4. И его можно было бы сразу задать. 
// Но вообще метод может работать для массива любого размера. Поэтому я всё же введу переменные для размеров.


int[,] FilSpiralArray(int m, int n)
{
    int[,] spiralArray = new int[m, n];
    int xs = 0;
    int ys = 0;
    int xf = spiralArray.GetLength(1);
    int yf = spiralArray.GetLength(0);
    for (int a = 1; a < ((m * n) + 1);)
    {
        for (int j = xs; j < xf; j++)
        {
            int i = ys;
            spiralArray[i, j] = spiralArray[i, j] + a;
            a++;
        }

        for (int i = (ys + 1); i < yf; i++)
        {
            int j = (xf - 1);
            spiralArray[i, j] = spiralArray[i, j] + a;
            a++;
        }
        for (int j = (xf - 2); j >= xs; j--)
        {
            int i = (yf - 1);
            spiralArray[i, j] = spiralArray[i, j] + a;
            a++;
        }
        for (int i = (yf - 2); i > ys; i--)
        {
            int j = xs;
            spiralArray[i, j] = spiralArray[i, j] + a;
            a++;
        }
        xf--;
        yf--;
        ys++;
        xs++;

    }
    return spiralArray;
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

int m = 4;
int n = 4;
int[,] array62 = FilSpiralArray(m, n);

PrintArray(array62);