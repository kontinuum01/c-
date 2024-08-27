// // На основе символов строки (тип string) сформировать массив
// // символов (тип char[]). Вывести массив на экран.
// // Указание
// // Метод строки ToCharArray() не использовать.
// // Пример
// // “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

void Main()
{

    System.Console.Write("Введите текст: ");
    string? str = Console.ReadLine();
    // char[] tempChar = str.ToCharArray();

    PrintCharArray(FromStringToCharArray(str));
}

char[] FromStringToCharArray(string? str)
{   
    char[] tempChar = new char[str!.Length];

    for(int i = 0; i < str.Length; i++)
    {
        tempChar[i] = str[i];
    }

    return tempChar;
}

void PrintCharArray(char[] c)
{
    System.Console.WriteLine("['" + string.Join("', '", c) + "']");
}

Main();