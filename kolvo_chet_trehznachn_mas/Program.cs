// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int size = 7;
int[] array = new int[size];
FillArray(array);
System.Console.WriteLine("[{0}]", string.Join(",", array));
Chetn(array);

void FillArray(int[] array)
{
    for (int i=0; i< array.Length; i++)
    {
        array[i] = new Random().Next(100,999);  
    }   
}

void Chetn(int[] array)
{ 
    int count = 0;
    for (int i =0; i< array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count = count+1;
        }
    }
    System.Console.WriteLine($"Количество четных элементов в массиве = {count}");
}

