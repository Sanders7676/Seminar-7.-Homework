// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// 1. Ввод с консоли двух переменных - номера строки и номера столбца
// 2. В методе проверка каждого элемента массива на равенство его i и j заданным с консоли значениям.
// Если такие i и j есть - вывести элемент на печать
// Если таких i и j нет, то вывести сообщение, что такого элемента в массиве нет.



Console.Write("Ведите номер строки на которой расположен интересующий Вас элемент массива:");

int rowNumber = InputInt();

Console.Write("Ведите номер столбца на которой расположен интересующий Вас элемент массива:");

int columnNumber = InputInt();

int[,] array = CreateRandom2DArray(3, 4);

PrintArray(array);




// Метод для приема чисел, вводимых через консоль

int InputInt()
{
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    
    if (isNum)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Введено некорректное значение.");
        return -1;
    }
}


// Метод генерации массива из случайных чисел

int[,] CreateRandom2DArray(int countOfRows, int countOfColumns)
{
    //Random random = new Random();
    //int[,] array = new int[countOfRows, countOfColumns];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            if (i == rowNumber && j == columnNumber)
                
            array[i, j] = random.Next(-10, 11);
        }
    }
    return array;
}



// Метод проверки наличия ячейки в массиве

bool CheckIfCellExistsInArray (int rowNumber, int columnNumber, int[,] array)




// Метод выдачи значения требуемой ячейки из массива

int[,] CreateRandom2DArray(int rowNumber, int columnNumber)
{
    int[,] array = new int[countOfRows, countOfColumns];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            if (i == rowNumber && j == columnNumber)
                
            //array[i, j] = random.Next(-10, 11);
        }
    }
    return array;
}






// Метод печати массива

void PrintArray(int[,] array)
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
