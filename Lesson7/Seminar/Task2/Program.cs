// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9

void Main()
{   
    int N = ReadInt("Введите число: ");

    System.Console.WriteLine(SumDigits(N));
}

int SumDigits(int number)
{
    if(number < 1) return 0;
    return number % 10 + SumDigits(number / 10);    
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();