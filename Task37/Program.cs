// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// 
Console.Write("Введите количество элементов в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int[N];
for (int i = 0; i < N; i++)
    array[i] = new Random().Next(0, 101);
Console.WriteLine(string.Join(" ", array));
int N2 = 0;
if (N % 2 > 0)
    N2 = N/2+1;
else 
    N2 = N/2;
int [] ResultArray = new int [N2];
for (int j = 0; j < N/2; j++)
    ResultArray[j] = array[j]*array[N-j-1];
if (N % 2 > 0)
{   
    ResultArray[N/2] = array[N/2];
    Console.WriteLine(string.Join(" ", ResultArray));
}
else
    Console.WriteLine(string.Join(" ", ResultArray));


