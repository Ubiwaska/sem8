// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.Clear();

Console.WriteLine("Enter the size of (m x n)- and (n x p)-matrices."); 
    Console.WriteLine("Enter m:"); 
    int m=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter n:"); 
    int n=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter p:"); 
    int p=Convert.ToInt32(Console.ReadLine());
    
    int[,] matrix1 = new int[m, n]; 
    int[,] matrix2 = new int[n, p]; 
    GetArray(matrix1); 
    GetArray(matrix2); 
    
    int[,] matrix_product = new int[m, p]; 
     
    for (int i = 0; i < m; i++) 
    { 
        for (int j = 0; j < p; j++) 
        { 
            matrix_product[i,j]=0;
            for (int k = 0; k < n; k++) 
            { 
                matrix_product[i,j]+=matrix1[i, k] * matrix2[k, j]; 
            } 
            
        } 
    } 
    Console.WriteLine("matrix_1"); 
    PrintArray(matrix1); 
    Console.WriteLine(); 
    Console.WriteLine("matrix_2"); 
    PrintArray(matrix2); 
    Console.WriteLine(); 
    Console.WriteLine("The product of matrix_1 and matrix_2 is"); 
    PrintArray(matrix_product);
    
    void GetArray(int[,] array) 
    { 
        for (int i = 0; i < array.GetLength(0); i++) 
        { 
            for (int j = 0; j < array.GetLength(1); j++) 
            { 
                array[i, j] = new Random().Next(1, 10);  
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