// напишите программу которая выводи массив из рандомного количества элементов(как решит сам пользователь), 
// заполненный 0 и 1 в случайном порядке.

int InputNum (string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

void FillArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next (0, 2);
    }
}

void PrintArray (int[] array)
{
    foreach (int value in array)
    {
       Console.Write(value + " "); 
    }
}

int size = InputNum("Введите размер массива");
int [] arr = new int [size];
FillArray(arr);
PrintArray(arr);
