//Задача: 
//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

Console.Write("Введите количество элементов массива: ");
int count = Convert.ToInt32(Console.ReadLine());
string[] StringArray = new string[count];
GenerateArray(StringArray);
Console.WriteLine("Исходнйы массив: ");
PrintArray(StringArray);
string[] StringArray2 = new string[count];
SearchElem(StringArray, StringArray2);
Console.WriteLine("Массив после сортировки: ");
PrintArray(SearchElem(StringArray,StringArray2));

void GenerateArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"Введите элемент номер {i+1}: ");    
        array[i] = Console.ReadLine();
        if (array[i] == "")
        {
            Console.Write($"Введите элемент номер {i+1} отличный от NULL: ");
            array[i] = Console.ReadLine();

        }
    }
}

void PrintArray(string[] array)
{   
    Console.Write("[ ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i] != null)
        {
            Console.Write($"'{array[i]}' ");
        }
    }
    Console.WriteLine("]");
}

string[] SearchElem(string[] array1, string[] array2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[i] = array1[i];
        }
    }
    return array2;
}