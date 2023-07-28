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
    string[] array; 
    array = new string[stringNumber];
 
    for(int i = 0; i < array.Length; i++)
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

int stringNumber = ReadInt("Введите количество элементов массива: ");
string[] arrayOfStrings= FillArray(stringNumber);
Console.WriteLine();
PrintArray(arrayOfStrings);