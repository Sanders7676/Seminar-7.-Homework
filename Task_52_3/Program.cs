// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] array = CreateRandom2DArray(3, 4);






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



// Метод нахождения сумм ячеек по столбцам в столбце

int GetColumnSums (int[,] array)
{
    int sum = 0;
      
    int[] columnSums = new int[array.GetLength(1)];
    
    
  
    for (var j = 0; j < array.GetLength(1); j++)
    {
        for (var i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
            
        }
        
      
    }
    return arr; 
    
    
// Метод нахождения среднего арифметического в столбце

int GetArithmeticalMean (int[,] array)
{
    int sum = 0;
      
    int arithmeticalMean = 0;
      
    int[] arithmeticalMean = new int[array.GetLength(1)];
    
    for (var j = 0; j < array.GetLength(1); j++)
    {
        for (var i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];                     
        }
        arithmeticalMean = sum / GetLength(0)
        
        arithmeticalMean [i, j];
      
    }
    return arr; 
