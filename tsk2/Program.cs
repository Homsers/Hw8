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

void PrintArray2(int[,] numbers)
{
for (int i = 0; i < numbers.GetLength(0); i++)
    {
    int sum = 0;
    int minSum = int.MaxValue, indexMin = 0;
    for (int j = 0; j <numbers.GetLength(1) ; j++)
    sum += numbers[i,j];
        if(sum< minSum)
        {
        minSum = sum;
        indexMin = i;
        }
    }
}

void PrintArray3(int[,] array)
{
    Console.WriteLine("String with minimum sum");
    int indexMin = 0;
                 for(int j = 0;j<array.GetLength(1);j++)
                     Console.Write(array[indexMin, j] + " ");
    
}

Console.WriteLine("Array");

int[,] myArray = GetArray(m, n, 0, 9);

PrintArray(myArray);
Console.WriteLine();
PrintArray2(myArray);
PrintArray3(myArray);



