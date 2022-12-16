// Задача 50. Напишите программу, которая на вход принимает 
// значение элемента в двумерном массиве, и возвращает позицию 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
int[,] a1 = { { 1, 2,  }, { 2, 3 }, { 3, 4 } };
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
bool check = false;
for (int i = 0; i < a1.GetLength(0); i++)
{
    for (int j = 0; j < a1.GetLength(1); j++)
    {
        if (num == a1[i, j])
        {
            check = true;
            Console.WriteLine($"Элемент имеет позицию {i} {j}");
        }
    }
}
if (check == false)
{
    Console.WriteLine("Такого элемента нет");
}

