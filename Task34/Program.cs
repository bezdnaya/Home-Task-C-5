// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Write("Задайте количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
int count = 0;
for (int index = 0; index < N; index++)
{
    array[index] = new Random().Next(100, 1000);
    if (array[index] % 2 == 0)
        count++;
}
Console.WriteLine(string.Join(" ", array));
Console.WriteLine($"Количество чётных элементов в массиве: {count}");


