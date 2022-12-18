/* Задача 50. 
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

1 7 -> такой позиции в массиве нет
*/


Console.Clear();
Console.WriteLine("Введите номер строки: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [3,4];
InputMatrix(matrix);

if (n > matrix.GetLength(0) || m > matrix.GetLength(1))
    Console.WriteLine("Такого элемента нет.");
else
    Console.WriteLine($"Значение элемента {n} строки и {m} столбца равно {matrix[n-1,m-1]}");

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {        
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = new Random().Next(-100, 100) / 10;
                Console.Write($"{matrix[i, j]} \t");
            }
            Console.WriteLine();   
        }
}
