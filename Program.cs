int CheckArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            count++;
    }
    return count;
}
string PrintArray(string[] array)
{
    string result = string.Empty;
    Console.WriteLine("Ваш массив :");
    result = "[ ";
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i], 1}";
        if (i < array.Length - 1)
            result += ", ";
    }
    result += " ]";
    return result;
}

string[] OutputArray(string[] array, int count)
{
    string[] result = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[result.Length - count] = array[i];
            count--;
        }
    }
    return result;
}

string[] imputArray = new string[] { };
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
imputArray = new string[n];
for (int i = 0; i < imputArray.Length; i++)
{
    Console.Write($" Введите {i + 1} элемент: ");
    imputArray[i] = Console.ReadLine();
}

int numberOfElements = CheckArray(imputArray);
string[] outputArray = OutputArray(imputArray, numberOfElements);
Console.WriteLine($"{PrintArray(outputArray)}");
