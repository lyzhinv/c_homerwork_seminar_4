// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine("Введите предельное число для массива");
int MaxNumber = int.Parse(Console.ReadLine()!);
int[] array = GetBinaryArray(8);

if (MaxNumber > 0)
{
    Console.WriteLine($"[{String.Join(", ", array)}]");
}
else
{
    Console.WriteLine("Ошибка, необходмо ввести число больше 0");
}

int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
    result[i] = new Random().Next(MaxNumber);
    }
    return result;
}