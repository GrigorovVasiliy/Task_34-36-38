Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-99, 99);

int sum = 0;

for (int i = 1; i < array.Length; i = i + 2)

    sum += array[i];

Console.WriteLine($"Случайный массив из трухзначных чисел:\n[{string.Join(", ", array)}]");
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях.: {sum}");