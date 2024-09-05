// Задача: Написать программу, которая из имеющегося массива 
//строк формирует новый массив из строк, длина которых меньше, 
//либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется 
//пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []



void Main()


{
int n = 3;
int size = 6;
string[] arrayOne = new string[size];
System.Console.WriteLine($"Введите набор символов, обозначающих значение стркогвого элемента массива, {size} раз через Enter, без пробелов: ");
//FormArray(arrayOne);
ArrayRandomly(arrayOne);
Console.Clear();
PrintArray(arrayOne);
System.Console.WriteLine();
System.Console.Write($"Новый массив, содержащий элементы, размер которых меньше или равен {n}: ");
if (SizeSecondArray(arrayOne) == 0) System.Console.WriteLine("Искомых элементов строкого массива для переноса в новый массива - нет");
else
{
    string[] arrayTwo = TransferElements(arrayOne);
    PrintArray(arrayTwo);
}


void FormArray(string[] arr)
{
    for (int i = 0; i < size; i++)
    {
        arr[i] = Console.ReadLine() ?? "";
    }
}


void ArrayRandomly(string[] arr)
{
    Random rand = new Random();
    string AlmostAllSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&**~";
    for(int i =0; i < size; i++)
    {
        int randElemSize = rand.Next(1,7);
        for (int j = 0; j < randElemSize; j++)
        {
            arr[i] += AlmostAllSymbols[rand.Next(0,AlmostAllSymbols.Length)];
        }
    }

}


void PrintArray(string[] arr)
{
    int arrLeng = arr.Length;
    System.Console.Write("[ ");
    for (int i = 0; i < arrLeng; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
    System.Console.Write("]");
}


int SizeSecondArray(string[] arr)
{
    int secondSize = 0;
    for (int i = 0; i < size; i++)
    {
        if (arr[i].Length <= n)
        {
            secondSize++;
        }
    }
    return secondSize;
}


string[] TransferElements(string[] arr)
{
    string[] arrayTwo = new string[SizeSecondArray(arrayOne)];
    for (int i = 0, j = 0; i < size; i++)
    {
        if (arr[i].Length <= n)
        {
            arrayTwo[j] = arr[i];
            j++;
        }
    }
    return arrayTwo;
}
}



Main();