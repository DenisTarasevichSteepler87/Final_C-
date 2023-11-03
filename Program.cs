Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array1 = new string[n];

void InputArray(string[] array)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write("Введите элемент №{0}:\r\n    ", i + 1);
        array1[i] = Console.ReadLine();
    }
}


void FillArray(string[] array, string[] arrayFill)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {
            arrayFill[j] = array[i];
            j++;
        }

}

void PrintArray(string[] array)
{
    for (int i = 0; i < array1.Length; i++)
        System.Console.Write($"{array[i]} ");
    System.Console.WriteLine();
}

string[] array2 = new string[array1.Length];
InputArray(array1);
System.Console.WriteLine("Введенный массив:");
PrintArray(array1);
FillArray(array1, array2);
System.Console.WriteLine("Полученный массив:");
PrintArray(array2);

