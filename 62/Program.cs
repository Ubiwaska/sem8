// Напишите программу, которая заполнит спирально массив

Console.Clear();

//algorithm for an (n,n) array 

Console.WriteLine("Enter the size of an (n,n)-array! ");
Console.WriteLine("Enter n:");
int n = Convert.ToInt32(Console.ReadLine());


int[,] array = new int[n, n];

int number = 1000;

int nx = n;
int coordinate = 0;

while (nx > 0)
{

    FillTheBorder(array, coordinate, nx, number);

    number += 4 * nx - 4;
    nx -= 2;
    coordinate += 1;

}

PrintArray(array);

void FillTheBorder(int[,] array, int coordinate, int nx, int number)
{

    for (int i = coordinate; i < coordinate + nx; i++)
    {
        array[coordinate, i] = number;
        number++;
    }
    for (int j = coordinate + 1; j < coordinate + nx; j++)
    {
        array[j, coordinate + nx - 1] = number;
        number++;
    }
    for (int i = coordinate + nx - 2; i >= coordinate; i--)
    {
        array[coordinate + nx - 1, i] = number;
        number++;
    }
    for (int j = coordinate + nx - 2; j > coordinate; j--)
    {
        array[j, coordinate] = number;
        number++;
    }

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