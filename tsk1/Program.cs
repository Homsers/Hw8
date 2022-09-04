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
    for (int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        for (int c = 0; c < numbers.GetLength(1) - 1; c++)
        {
            if (numbers[i, c] < numbers[i, c + 1])
            {
                int temp = 0;
                temp = numbers[i, c];
                numbers[i, c] = numbers[i, c + 1];
                numbers[i, c + 1] = temp;
                
            }
        }
    }
}

}
void PrintArray3(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}


Console.WriteLine();
Console.WriteLine("Array without ordered values");


int[,] myArray = GetArray(m, n, 0, 9);

PrintArray(myArray);
Console.WriteLine();
Console.WriteLine("Array with ordered values");
PrintArray2(myArray);
PrintArray3(myArray);
