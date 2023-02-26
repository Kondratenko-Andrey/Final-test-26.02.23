void PrintArr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

string[] arrWords = {"The", "day", "is", "very", "serious", "!"};

Console.WriteLine("Исходный массив представлен ниже:");
PrintArr(arrWords);

int count = 0;

for (int i = 0; i < arrWords.Length; i++)
{
    if(arrWords[i].Length <= 3) count ++;
}

string[] arrWordsNew = new string[count];

count = 0;

for (int i = 0; i < arrWords.Length; i++)
{
    if(arrWords[i].Length <= 3)
    {
        arrWordsNew[count] = arrWords[i];
        count ++;
    } 
}

Console.WriteLine("\nНа основе исходного массива сформирован новый, в котором элементы имеют не более трёх символов:");
PrintArr(arrWordsNew);
