// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] elements = CreatArray();
PrintArray(elements);
int countMoreZero = FindMoreThanZero(elements);
System.Console.WriteLine($"Количество чисел больше нуля равно {countMoreZero}");

int[] CreatArray()
{
    Console.WriteLine("Введите количество элементов M массива:");
    int elementsCount = int.Parse(Console.ReadLine()!);
    int[] array = new int[elementsCount];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("Массив: ");
    foreach (int number in array)
    {
        Console.Write($"{number} ");
    }
    System.Console.WriteLine();
}

int FindMoreThanZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count += 1;
    }
    return count;
}
