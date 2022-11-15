string[] arrayIn = new string[3] { "Hello", "2", "world" };
string[] arrayOut = new string[arrayIn.Length];

void CutArray(string[] arrayIn, string[] arrayOut)
{
    int count = 0;
    for (int i = 0; i < arrayIn.Length; i++)
    {
        if (arrayIn[i].Length <= 3)
        {
            arrayOut[count] = arrayIn[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
}

CutArray(arrayIn, arrayOut);
PrintArray(arrayOut);