// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double [] array = new double [new Random().Next(4, 20)];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
}
double min = array[0];
double max = array[0];
for (int j = 0; j < array.Length; j++)
    if (array[j] > max)
        max = array[j];
    else if (array[j] < min)
        min = array[j];
Console.WriteLine(string.Join(" ", array));
Console.WriteLine($"Разница между максимальным ({max}) и минимальным ({min}) элементами массива {max - min}");
