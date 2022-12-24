/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"];
["Russia", "Denmark", "Kazan"] -> [] 
*/

void FillArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i + 1}-ый элемент массива : ");
        arr[i] = Console.ReadLine()!;
        while (true)
        {
            if (arr[i] == "")
            {
                Console.Write($"Внимание! Введите любое значение, кроме пустой строки: ");
                arr[i] = Console.ReadLine()!;
            }
            else break;
        }
    }
};

void FillArrayStringsLengthLessOrEqualThree(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    };

    string[] array = new string[count];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            array[j] = arr[i];
            j++;
        }
    }
    Console.WriteLine("[ " + string.Join(", ", array) + " ]");
};

Console.Write("Сколько будет слов в массиве? : ");
int sizeArray = 0;

while (true)
{
    if (Int32.TryParse(Console.ReadLine(), out sizeArray) && sizeArray > 0)
    {
        break;
    }
    else
    {
        Console.Write("Внимание! Введите целое число, больше 0 : ");
    }
};

string[] array = new string[sizeArray];

FillArray(array);
FillArrayStringsLengthLessOrEqualThree(array);