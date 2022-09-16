// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int size = 5;
double[] array = FillArray(size);
System.Console.WriteLine("[{0}]", string.Join(" , ", array));

double min, max;
Diffmaxmin(array, out min, out max);
System.Console.WriteLine($"Min = {min}; Max = {max}");
double diff = max - min;
System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {diff}");

double[] FillArray(int size)
{
    double[] array = new double[size];
     for (int i = 0; i < array.Length; i++)
     {
        array[i] = new Random().NextDouble()*100;
        array[i] = Math.Round(array[i], 2);
     }
     return array;
}
// double[] FillArray(int size)
// {
//     double[] array = new double[size];
//      for (int i = 0; i < array.Length; i++)
//      {
//         array[i] = new Random().Double();
//      }
//      return array;
// }

void Diffmaxmin(double[] array, out double min, out double max)
{
    min = array[0];
    max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        min = array[i];
        if (array[i] > max)
        max = array[i];
    }
}