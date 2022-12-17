Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine());
double[] array = new double[n];

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 99);

double sum = 0, max = 1, min = 99;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        max = array[i];
    if (array[i] < min)
        min = array[i];
}
sum = max - min;
Console.WriteLine($"Случайный массив из чисел:\n[{string.Join("; ", array)}]");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {sum}");