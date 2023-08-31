//  напишите программу которая принимает на вход число и выводит колличество цифр в числе
// var1
/*int InputNum (string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

/int num = InputNum("Введите число: ");
int i; // i вынесли за цикл потому что нам потом нужно ее распечатать, иначе она бы существовала только внутри цикла и была бе недоступна вне его.
for (i = 0; num != 0; i++)
{
    num /= 10;
}

Console.WriteLine(i); */

// var2

int InputNum (string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int num = InputNum("Введите число: ");
int i; 
for (i = 0; num != 0; i++, num /= 10);

Console.WriteLine(i);





