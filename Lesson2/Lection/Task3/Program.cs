// Напишите программу, которая выводит третью с
// конца цифру заданного числа или сообщает, что
// третьей цифры нет.
// 456 => 6
// 7812 => 1
// 91 => Третьей цифры нет

// 123415 / 1000 % 10
// 12412567 / 100000 % 10
// 1234 / 10 % 10
// 123566 / 10 -> 12356 / 10 -> 1235 / 10 -> 123 % 10 -> 3

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99)
{
while(number > 999)
number /= 10; // number = number / 10

Console.WriteLine(number % 10);
}
else
{
System.Console.WriteLine("Третьей цифры нет!");
}