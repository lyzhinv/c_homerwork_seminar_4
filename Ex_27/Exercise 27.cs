// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе {num} = {GetSum(num)}");

int GetSum(int number)
{
    int sum = 0;
    int size = Convert.ToString(number).Length;
    for (int i = 0; i < size; i++)
    {
        int temp = number - number % 10;
        sum = sum + (number - temp);
        number = number / 10;
    }

    return sum;
}
