// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear(); 
 
    Console.WriteLine("Enter the size of the array."); 
    Console.WriteLine("Enter the number of rows:"); 
    int number_rows=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the number of columns:"); 
    int number_columns=Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int[number_rows, number_columns]; 
    GetArray(array); 
    PrintArray(array);
    Console.WriteLine(); 
    
   SortEachRow(array);
    PrintArray(array);  
    
   void SortEachRow(int[,] array)
    {
        int n=array.GetLength(1);

        for (int i = 0; i < array.GetLength(0); i++) 
        {
            for(int j=0; j<n; j++)
            {
                for (int k=0; k<n-1-j; k++)  
                {  
                    if (array[i, k] < array[i, k + 1])
                    {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                    }
                }

            }

        }
        
    } 
  
     
    void GetArray(int[,] array) 
    { 
        for (int i = 0; i < array.GetLength(0); i++) 
        { 
            for (int j = 0; j < array.GetLength(1); j++) 
            { 
                array[i, j] = new Random().Next(0, 10); 
            } 
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