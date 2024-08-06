System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int a = 0;

while (number > a)
{
  a = number % 10;
}
Console.Write($"{a} ");