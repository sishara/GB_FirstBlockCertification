//Задача :
// Написать программу, которая из имеющегося массива строк формирует массив из
// строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполиения алгоритма. При решении не рекомендуется пользоваться коллекциями
//, лучше обойтись исключительно массивами. 

//примеры:
//["hello","2","world",":)"] -> ["2",":)"]
//["1234", "1567", "-2", "computer science"] -> ["-2"]

string[] FindWords(string[] array)
{

    int goodElements = 0;
    string currentWord;
    string[] result = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        currentWord = array[i];
        if (currentWord.Length <= 3)
        {
            result[goodElements] = currentWord;
            goodElements += 1;
        }


    }


    string[] finalResult = new string[goodElements];
    Array.Copy(result, finalResult, goodElements);
    return finalResult;
}

void PrintArray(string[] array)
{
    Console.WriteLine($"New array of words : [ {String.Join(" , ", array)} ]");

}

Console.Clear();
Console.WriteLine("Input words using space as separator and [Enter]-key as finish input sequence :");
string[] arrayOfWords = Console.ReadLine().Split(" ");
string[] goodWords = FindWords(arrayOfWords);

PrintArray(goodWords);
