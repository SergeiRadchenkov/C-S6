/* Напишите программу, которая перевернёт одномерный
массив (последний элемент будет на первом месте, а первый - на
последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6 */

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
    return new int[size];

void FillArray(int[] arr, int minValue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
        arr[i] =rnd.Next(minValue, maxValue + 1);
}

void PrintArray