// напишите программу которая принимает на вход число N и выдает цифры от 1 до N

int InputNum (string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}
int SumNums (int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
      sum += i;  
    }
    return sum;
}

int num = InputNum("Введите число: ");
int sum = SumNums(num);
