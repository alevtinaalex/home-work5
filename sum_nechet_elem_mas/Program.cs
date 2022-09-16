// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = 5;
int[] array = new int[size];
FillArray(array);
System.Console.WriteLine("[{0}]", string.Join(",", array));
Sum_nechet(array);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 100);
}

void Sum_nechet(int[] array)
{
    int summa = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            summa = summa + array[i];
        }
    }
    System.Console.Write("Сумма нечетных элементов в массиве = ");
    System.Console.WriteLine(summa);
}
