/*Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
 либо задать на старте выполнения алгоритма.*/
Console.Clear();
int GetArraySize(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        int size;
        if(int.TryParse(Console.ReadLine(), out size) && size > 0)
            return size;
        Console.WriteLine(errorMessage);
    }
}
string[] GetArray(int size)
{
    string[] myArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"\nВведите элемент массива под индексом {i}: ");
        myArray[i] = Console.ReadLine();
    }
    return myArray;
}
static void ReturnNewArray(string[] myArray)
{
    string[] NewArray = new string[0];
    foreach (var value in myArray)
    {
        if (value.Length <= 3)
        {
            Array.Resize(ref NewArray, NewArray.Length + 1);
            NewArray[NewArray.Length - 1] = value;
        }
    }
    if(NewArray.Length > 0)
    {
        Console.WriteLine(String.Join(", ", NewArray));
    }
    else
    {
        Console.WriteLine("Все элементы массива >= 3");
    }
}
int size = GetArraySize("Введите колличество элементов массива: ", "Размер массива должен быть больше 0!");
string[] elementsArr = GetArray(size);

Console.WriteLine("\nВывод исходного массива: ");
Console.WriteLine(String.Join(", ", elementsArr));

Console.WriteLine("\nВывод нового массива: ");
ReturnNewArray(elementsArr);