//Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

Console.Clear();
int[] array = new int[123];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 500);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
for (int j = 0; j < array.Length; j++)
{
    if (array[j] > 9 & array[j] < 100)
        count++;
}
Console.WriteLine();
Console.WriteLine($"Массив содержит следующее количество элементов из отрезка [10,99]: {count} ");
Console.WriteLine();
