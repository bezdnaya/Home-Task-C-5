// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double [] array = new double [new Random().Next(4, 20)];
double min = 0;
double max = array[0];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
    min = array[i];
    if (array[i] > max)
        max = array[i];
    else if (array[i] < min)
        min = array[i];
}
Console.WriteLine(string.Join(" ", array));
Console.WriteLine($"Разница между максимальным ({max}) и минимальным ({min}) элементами массива {max - min}");
