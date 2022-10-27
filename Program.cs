string[] array = new string[7] { "1555", "25555", "333", "433", "5444", "final", "alo" };
string[] finalarray = new string[array.Length];

void ArrayWithIf(string[] array, string[] finalarray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            finalarray[count] = array[i];
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
}
ArrayWithIf(array, finalarray);
PrintArray(finalarray);