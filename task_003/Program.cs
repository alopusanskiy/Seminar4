// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] array, int minrange, int maxrange)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(minrange, maxrange);
    }
}

void PrintArray (int[] array)
{
    System.Console.WriteLine(string.Join(" ", array));
}

int[] arr = new int[8];

FillArray(arr, 100, 150);
PrintArray(arr);