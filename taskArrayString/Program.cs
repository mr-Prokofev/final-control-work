Console.Clear();

string[] LenArrayLessOrRequalThree(string[] arr, int lenNewArray) // Создание нового массива из элементов >=3
{
    string[] newArray = new string[lenNewArray];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArray[count] = arr[i];
            count++;
        }
    }
    return newArray;
}

int CountArrayStringLessOrRequalThree(string[] arr) // проверка на наличие элементов >=3
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length<=3) count++;
    }
    return count;
}

void PrintArray(string[] array) // печать массива
{
    Console.Write("[");
    for (int i = 0; i<array.Length; i++)
    {   if (i<array.Length-1) Console.Write($"{array[i]},  ");
        else Console.Write($"{array[i]}");   
    }
    Console.Write("]");
}

string[] array = new string[]{"123", "qwe", "computer science", "Russia", "Дом", "Denmark", "Kazan"};
int resultFuncCountArrayStringLessOrRequalThree = CountArrayStringLessOrRequalThree(array);
if (resultFuncCountArrayStringLessOrRequalThree == 0) 
{
    Console.WriteLine("Массив пустой - искомых элементов нет");
    return;
}
else
{
string[] resultFuncLenArrayLessOrRequalThree = LenArrayLessOrRequalThree(array, resultFuncCountArrayStringLessOrRequalThree);
PrintArray(resultFuncLenArrayLessOrRequalThree);
}




