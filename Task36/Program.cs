// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих 
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int [] array = new int[new Random().Next(4, 11)];
int Sum = 0;
for (int index = 0; index < array.Length; index++)
{
    array[index] = new Random().Next(0, 100);
    if (index % 2 > 0)
        Sum += array[index];
}
Console.WriteLine (string.Join(" ", array));
Console.WriteLine($"Сумма элементов на нечётных позициях = {Sum}");