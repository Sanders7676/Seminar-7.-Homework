// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



int[,] array = CreateRandom2DArray(3, 4);

Console.Write("Ведите номер строки на которой расположен интересующий Вас элемент массива:");

int rowNumber = InputInt();

Console.Write("Ведите номер столбца на которой расположен интересующий Вас элемент массива:");

int columnNumber = InputInt();

PrintArray(array);

bool arrayContainsCell = CheckIfCellExistsInArray (rowNumber, columnNumber, array)

if (arrayContainsCell == true)
{    
    int requiredCellValue = FindRequiredCellValue (int rowNumber, int columnNumber, int[,] array);
    Console.WriteLine($"Интересующая Вас ячейка массива имеет значение {requiredCellValue}.");
}
else
{
    Console.WriteLine("В имеющемся массиве отсутствует ячейка с заданными Вами параметрами");
}

    
    
    
// Метод генерации массива из случайных чисел

int[,] CreateRandom2DArray(int countOfRows, int countOfColumns)
{
    int[,] arr = new int[countOfRows, countOfColumns];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-10, 11);
        }
    }
    return arr;
}



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



// Метод проверки наличия ячейки в массиве

bool CheckIfCellExistsInArray (int rowNumber, int columnNumber, int[,] array)
{
    if (rowNumber <= array.GetLength(0) && columnNumber <= array.GetLength(1)
    {
        return true;
    }
    renurn false
}


// Метод выдачи значения требуемой ячейки из массива

int FindRequiredCellValue (int rowNumber, int columnNumber, int[,] array)
{
    int result
    
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            if (i == rowNumber - 1 && j == columnNumber - 1)
            {
                result = array[i, j];
                //return result;
            }
        }
    }
    return result$
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
