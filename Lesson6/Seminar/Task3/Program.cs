// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

void Main()
{

    System.Console.Write("Введите текст: ");
    string? str = Console.ReadLine()!.ToLower();
    System.Console.WriteLine(CountVowels(str));
}

int CountVowels(string? str)
{
    int count = 0;

    foreach(char letter in str)
        if(isVowel(letter))
            count++;

    return count;
}

bool isVowel(char c)
{
    return "aeiouy".Contains(c);// A != a
}

Main();
