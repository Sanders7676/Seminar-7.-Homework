// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] array = CreateRandom2DArray(3, 4);
Console.Write("Средние арифметические по столбцам имеют следующие значения: "
PrintArray(сolumnArithmeticalMean)




// Метод генерации массива из случайных чисел

int[,] CreateRandom2DArray(int countOfRows, int countOfColumns)
{
    int[,] arr = new int[countOfRows, countOfColumns];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            arr[i, j] = random.Next(-10, 11);
        }
    }
    return arr;
}



// Метод нахождения среднего арифметического в столбце

int GetArithmeticalMean (int[,] array)
{
    double[] arithmeticalMean = new int[array.GetLength(1)];
    
    for (int a = 0; a < array.GetLength(1); a++)
        
         int sum = 0;
         
         for (var j = 0; j < array.GetLength(1); j++)
         {
            for (var i = 0; i < array.GetLength(0); i++)
            {
                sum = sum + array[i, j];                     
            }
         }
         columnArithmeticalMean[a] = sum / array.GetLength(0)
    }
    return columnArithmeticalMean; 
}



//Метод печати массива

void PrintArray(var[] array)
{
    Console.WriteLine($"({string.Join(" ; ", array)})");
}
