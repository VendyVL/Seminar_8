// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Как вывести куб построчно, вот в чём вопрос. Это же куб!


int[,,] MakeCubeArray(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = rand.Next(10, 100);
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k})   ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

int x = 4; // Группа переменных, которые можно задавать
int y = 3;
int z = 2;

int[,,] cubeArray = MakeCubeArray(x, y, z);
PrintArray(cubeArray);

//Кажется как-то так. По крайней мере оно работает.