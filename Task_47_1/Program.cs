
//Для чисел с плавающей запятой используется Random.NextDouble(), который возвращает случайное дробное число в интервале [0; 1)

// Так как распределение случайной величины равномерное, то мы можем перевести данный единичный промежуток в любой другой. Пусть вам нужно получить случайное число в промежутке [begin; end), тогда вам необходимо выполнить следующую операцию: RandomObj.NextDouble() * (end - begin) + begin.

// Благодаря такому преобразованию, единичный промежуток "растягивается" до нужной вам длины и "передвигается" на нужное начало.

// В вашем случае код будет выглядеть так:

// Random rnd = new Random();
// double val = rnd.NexDouble() * (53.44 + 10.34) - 10.34;


// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine();

double[,] array = CreateRandom2DArray(3, 4);

PrintArray(array);

Console.WriteLine();



// Метод формирования массива

double[,] CreateRandom2DArray(int countOfRows, int countOfColumns)
    {
        Random random = new Random();

        double[,] array = new double[countOfRows, countOfColumns];

        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = Math.Round(random.NextDouble() * ((10.00 + 9.99) - 9.99), 1);
            }
        }
        return array;
    }


// Метод печати двумерного массива

void PrintArray(double[,] array)
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
