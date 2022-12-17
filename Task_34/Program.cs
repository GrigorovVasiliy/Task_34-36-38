Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 999);

int count = 0;

for (int i = 0; i < array.Length; i++)
    if (array[i] % 2 == 0)
        count++;

Console.WriteLine($"Случайный массив из трухзначных чисел:\n[{string.Join(", ", array)}]");
Console.WriteLine($"Kоличество чётных чисел в массиве: {count}");