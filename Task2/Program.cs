// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

double sum = 0;
for (int i = 0; i <= mass.Length; i++)
{
    if (i>0 && i % 2 > 0) 
    {
        sum += mass[i];
        Console.Write(mass[i] + " ");
    }  
}
System.Console.WriteLine();
System.Console.WriteLine($"Сумма элементов с нечётным индексом = {sum}");


