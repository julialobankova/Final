
void Method(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
string[] array1 = new string[5] {"1234", "56", "home", "world", "mrs"};
string[] array2 = new string[array1.Length];
Method(array1, array2);
Console.Write("Исходный массив:");
PrintArray( array1);
Console.Write("Новый массив:");
PrintArray(array2);