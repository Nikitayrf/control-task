# Задача

> Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

> Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"];
["Russia", "Denmark", "Kazan"] -> [] 


## Алгоритм решения программы ##

1. Работа программы начинается с запроса у пользователя о том сколько будет слов в массиве. Ввод пользовательских данных организован с консоли. Это необходимо для вычисление первоначальной длины массива. Первоначальная длина храниться в переменной _sizeArray_
```
Console.Write("Сколько будет слов в массиве? : ");
int sizeArray = 0; 
```
2. На следующем этапе организован бесконечный цикл __while(true)__ проверки корректности введенных пользовательских данных. Корректные данные должны удовлетворять условию, что длина массива _sizeArray_ > 0. В противном случае выводиться ошибка и цикл повторяется.
``` csharp
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
```

3. Создаем массив типа string с назанием _array_ и длинной _sizeArray_
```
string[] array = new string[sizeArray];
```

4. Вызов метода ***FillArray*** с аргументом массив _array_
```
FillArray(array);
```

5.   Работа void метод ***FillArray***  заключается в поэлементном наполнение массива _array_ пользовательскими данными введенными с консоли.
```
Console.Write($"Введите {i + 1}-ый элемент массива : ");
arr[i] = Console.ReadLine()!;
```

Работа метода построена на цикле __for__ ограниченного длиной _arr.Length_
```
for (int i = 0; i < arr.Length; i++)
```

Так же организованна проверка ввода пользовательских данных. Условием не корректных данных является введенная пользователем пустая строка __arr[i]=""__

### Метод ***FillArray*** ###
``` csharp
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
```

6. Вызов метода ***FillArrayStringsLengthLessOrEqualThree*** с аргументом _array_ ранее заболненный методом ***FillArray***.
```
FillArrayStringsLengthLessOrEqualThree(array);
```
7. Работа метода void ***FillArrayStringsLengthLessOrEqualThree*** основана на двух циклах __for__. Его цель создать новый массив из заданного массива удовлетворящей условию, что в него войдут элементы длина которых, равна или меньше 3 символов.

7.1 Первый цикл __for__ вычисляет и записывает длину нового массива в переменную _count_.
``` csharp
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    };
```
7.2 Второй цикл по элементно записывает значения удовлетворяющие условию (длина элемента равна или меньше 3) в новый массив _array_
``` csharp
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
```
7.3 Вывод массива в консоль с помощью встроенного метода _Join_ 
```
Console.WriteLine("[ " + string.Join(", ", array) + " ]");
```
### Метод ***FillArrayStringsLengthLessOrEqualThree*** ###
``` csharp
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
```