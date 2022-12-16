// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
double[,] a = new double[9, 9];
double[] b = new double[9];

for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        Random rnd = new Random();
        a[i, j] = rnd.Next(10, 1000);
        Console.Write(a[i, j] + " ");
    }
    Console.WriteLine();
}

for (int i = 0, k = 0; i < 9; i++)
{
    double summa = 0;
    for (int j = 0; j < 9; j++)
    {
        summa = a[i, j];
    }
    b[k] = summa / 9;
    Console.WriteLine($"Среднее арифметическое столбца {i} равно: " + b[k]);
    k++;
}
