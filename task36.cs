void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(10, 50);
}

int sumNumbers(int[] array)
{
    int sum = 0;
    int i = 0;
    while (i < array.Length)
    {
        sum = sum + array[i];
        i = i + 2;
    }
    return sum;
}

Console.Clear();
Console.WriteLine("Введите количество элементов массиве: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int [n];
InputArray(array);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine(sumNumbers(array));