/*Задача: Написать программу, которая из имеющегося массива строк формирует 
массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*/

int n = 3;
int size = 6;
string[] arrayOne = new string[size];
Console.WriteLine($"Введите данные {size} раз без пробелов через Enter ");
//FillArray(arrayOne);
FillArrayRandomly(arrayOne);
Console.Clear();
PrintArray(arrayOne);
Console.WriteLine();
Console.WriteLine($"Новый массив, содержащий элементы,размер которых меньше либо равен {n}:");
if (GetSizeofSecondArray(arrayOne) == 0) { Console.WriteLine("искомых элементов строкового масива для переноса -нет"); }
else
{
    string[] arrayTwo = TransferElements(arrayOne);
    PrintArray(arrayTwo);
}
void FillArrayRandomly(string[] arr)
{
    Random random = new Random();
    string AllSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    for (int i = 0; i < size; i++)
    {
        int randomElementSize = random.Next(1,7);
        for (int j = 0; j < randomElementSize; j++)
        {
            arr [i] += AllSymbols[random.Next(0,AllSymbols.Length)];
        }
    }
}

void FillArray(string[] arr)
{
    for (int i = 0; i < size; i++)
    {
        arr[i] = Console.ReadLine() ?? "";
    }
}

void PrintArray(string[] arr)
{
    int arrLength = arr.Length;
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write("]");

}

int GetSizeofSecondArray(string[] arr)
{
    int secondsize = 0;
    for (int i = 0; i < size; i++)
    {
        if (arr[i].Length <= n)
        {
            secondsize++;
        }
    }
    return secondsize;

}
string[] TransferElements(string[] arr)
{
    string[] arrayTwo = new string[GetSizeofSecondArray(arrayOne)];
    
    for (int i = 0, j = 0; i < size; i++)
    {
        if (arr[i].Length <= n)
        {
          arrayTwo[j] = arr[i];
          j ++;
        }
    }
    return arrayTwo;
}