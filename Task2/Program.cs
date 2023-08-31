// напишите программу которая принимает на вход число и выводит колличество цифр в числе

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int count = 0;
while(number != 0)
{
    number /= 10;
    count ++;
}
Console.WriteLine(count);

