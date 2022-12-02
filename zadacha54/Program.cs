// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] Generate2DArray(int lengthRow, int lengthCol, int deviation)
{
    int[,] array = new int[lengthRow, lengthCol];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            array[i, j] = new Random().Next(-deviation, deviation + 1);
        }
    }
    return array;
}

void printColor(string information, ConsoleColor color, bool newLine = false)
{
    Console.ForegroundColor = color;
    Console.Write(information);
    Console.ResetColor();
    if (newLine)
    {
        Console.WriteLine();
    }
}

void print2dArray(int[,] array, string Name = "")
{
    printColor(Name, ConsoleColor.DarkCyan, true);
    Console.Write("\t");
    for (int i = 0; i < array.GetLength(1); i++)
    {
          printColor(i + "\t", ConsoleColor.DarkYellow,(i >= array.GetLength(1) - 1));
    }
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printColor(i + "\t", ConsoleColor.DarkYellow);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }

}

void changeLinesOfArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
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

int[,] generatedArray = Generate2DArray(5,5,10);
print2dArray(generatedArray, "Изначальный массив");
changeLinesOfArray(generatedArray);
print2dArray(generatedArray, "Измененный массив");