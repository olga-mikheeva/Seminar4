// напишите программу которая принимает на вход число N и выводит произведение чисел от 1 до N

int InputNum (string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int Factorial (int num)
{
    int mul = 1;
    for (int i = 2; i <= num; i++) // можем сразу записать int i = 2, потому что в первой итерации если i = 1 будем умножать 1*1
    {
       mul *= i; 
    }
    return mul;
}

int num = InputNum("Введите число: ");
int fact = Factorial(num);
Console.WriteLine(fact);