// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 2 -4 = 16

Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetPow(num2));


int GetPow (int numbersB){
    int pow = 1;
    for (int i = 0; i < num2; i++){
        pow = pow * num1;
    }
    return pow;
}