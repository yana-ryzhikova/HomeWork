// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateArray(int lenRows, int lenColumns)
{
    int[,] array = new int[lenRows, lenColumns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

bool ValidateMatrix(int[,] arrayA, int[,] arrayB)
{
    if (arrayA.GetLength(1) == arrayB.GetLength(0))
    {
        return true;
    }
    return false;
}

int[,] MatrixProduct(int[,] arrayA, int[,] arrayB)
{
    int [,] arrayC = new int [arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            arrayC[i,j] = 0;
            for (int c = 0; c < arrayA.GetLength(1); c++)
            {
                {
                    arrayC[i,j] +=  arrayA [i,c]* arrayB [c,j];
                }
            }
        }
    }
    return arrayC;
}


int[,] matrixA = CreateArray(2, 3);
int[,] matrixB = CreateArray(3, 3);
PrintArray(matrixA);
System.Console.WriteLine();
PrintArray(matrixB);
System.Console.WriteLine();

if(ValidateMatrix(matrixA, matrixB))
{
    int[,] matrixAB = MatrixProduct(matrixA, matrixB);
    System.Console.WriteLine("Произведение двух матриц равно:");
    PrintArray(matrixAB);
}
else
{
    System.Console.WriteLine("Произведение матриц некоммутативно!");
}