//1D
using System.Numerics;

int[] Array1D = new int[5];

Console.Write("{");
foreach (int number in Array1D)
{
    Console.Write(number.ToString()+ ",");
}
Console.WriteLine("}");

int[,] Array2D = new int[8,8];

Console.Write("{");
foreach (int number in Array2D)
{
    Console.Write(number.ToString()+ ",");
}
Console.WriteLine("}");

for(int i=0; i < Array2D.GetLength(0); i++)
{
    for (int j = 0; j < Array2D.GetLength(1);j++)
    {
        Console.Write($"{Array2D[i,j]}");       
    }
    Console.WriteLine();
}

//ForEach method

Array.ForEach(Array1D, Console.WriteLine);

Array.ForEach(ArrayD, Console.WriteLine);