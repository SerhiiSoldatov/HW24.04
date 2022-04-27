// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.
// [3 7 22 2 78] -> 76

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int[] mass = new int[10];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(10, 100);
}
Print(mass);
int max = 0;
int min = 0;
int n;
for (int i = 0; i < mass.Length; i++)
{
    n = mass[i];
    min = mass[i];
    if (n < min) min = n;
    if (n > max) max = n;
}
Console.WriteLine($"Максимум: {max}; Минимум: {min}");
int x = max - min;
System.Console.WriteLine(x);