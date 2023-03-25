// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.Clear();
Console.Clear(); 
 
    Console.WriteLine("Enter the size of the array."); 
    Console.WriteLine("Enter the number of rows:"); 
    int number_rows=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the number of columns:"); 
    int number_columns=Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int[number_rows, number_columns]; 
    GetArray(array); 
    PrintArray(array); 
    
    
    int minSumLine = 0; 
    int sumLine = SumLineElements(array, 0); 
    for (int i = 1; i < number_rows; i++) 
    { 
        int tempSumLine = SumLineElements(array, i); 
        if (sumLine > tempSumLine) 
        { 
            sumLine = tempSumLine; 
            minSumLine = i; 
        } 
    } 
    
    Console.WriteLine($"{minSumLine + 1} - the row with the smallest sum of the elements ({sumLine})"); 
     
  
    int SumLineElements(int[,] array, int i) 
    { 
        int sumLine = array[i, 0]; 
        for (int j = 1; j < array.GetLength(1); j++) 
        { 
            sumLine += array[i, j]; 
        } 
        return sumLine; 
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