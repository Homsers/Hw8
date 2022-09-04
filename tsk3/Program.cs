Console.Write("m=");
int m = int.Parse(Console.ReadLine());
Console.Write("n=");
int n = int.Parse(Console.ReadLine());

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int [m, n];
    
    for (int i = 0; i<m; i++)
        for(int j=0; j<n; j++)
           result[i, j] = new Random().Next(minValue, maxValue+1);

    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i<array.GetLength(0); i++) {
        for(int j = 0; j<array.GetLength(1); j++)
           Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}


int[,] array = new int[m, n];
int[,] second = new int[m, n];
int[,] result = new int[m, n];

void PrintArray2(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < second.GetLength(1); j++)
    {
        result[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            result[i, j] += array[i, k] * second[k, j];
        }
    }
}
}

void PrintArray3(int[,] array)
{
    for (int i = 0; i<array.GetLength(0); i++) {
        for(int j = 0; j<array.GetLength(1); j++)
           Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

Console.WriteLine();


int[,] myArray = GetArray(m, n, 0, 9);
int[,] myArray2 = GetArray(m, n, 0, 9);
PrintArray(myArray);
Console.WriteLine();
PrintArray3(myArray2);
PrintArray2(result);