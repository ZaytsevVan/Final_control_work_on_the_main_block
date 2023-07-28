// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

string[] FillArray(int stringNumber)
{
    string[] array = new string[stringNumber];
 
    for(int i = 0; i < stringNumber; i++)
    {
        Console.WriteLine("Введите элемент массива array[{0}] ", i);
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.Write("[" + string.Join(", ", array) + "]");
}

string[] ChangingTheArray(string[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length < 4)
        count++;
    }

    string[] newArray = new string[count];
    int index = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length < 4)
        {
            newArray[index] = array[i];
            index++;
        }    
    }
    return newArray;
}

void Main()
{
    int stringNumber = ReadInt("Введите количество элементов массива: ");
    string[] arrayOfStrings= FillArray(stringNumber);
    Console.WriteLine();
    Console.WriteLine("Заполненный вами массив выглядит так: ");
    PrintArray(arrayOfStrings);
    Console.WriteLine();
    Console.WriteLine("Если в вашем массиве оставить только строки из трех символов то он будет выглядеть так: ");
    string[] newArrayOfStrings = ChangingTheArray(arrayOfStrings);
    PrintArray(newArrayOfStrings);
}

Main();