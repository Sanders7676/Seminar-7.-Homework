// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



double[,] array = CreateRandom2DArray(3, 4);

Print2DArray(array);

double[] columnArithmeticalMean = GetArithmeticalMean(array);

Console.Write("Средние арифметические по столбцам имеют следующие значения: ");

PrintArray(columnArithmeticalMean);



// Метод генерации массива из случайных чисел

double[,] CreateRandom2DArray(int countOfRows, int countOfColumns)
{
    Random random = new Random();

    double[,] array = new double[countOfRows, countOfColumns];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}



// Метод нахождения среднего арифметического в столбце

double[] GetArithmeticalMean(double[,] array)
{
    double[] resultArray = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        resultArray[j] = Math.Round(sum / array.GetLength(0), 1);
    }

    return resultArray;
}



//Метод печати массива

void PrintArray(double[] columnArithmeticalMean)
{
    Console.WriteLine($"({string.Join(" ; ", columnArithmeticalMean)})");
}



// Метод печати двумерного массива

void Print2DArray(double[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}




