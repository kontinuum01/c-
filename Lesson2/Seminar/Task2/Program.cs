/*Напишите программу, которая принимает 
на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 
0 и выдаёт номер координатной четверти плоскости, 
в которой находится эта точка.*/

Console.Write("Введите координату х: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y: ");
int y = Convert.ToInt32(Console.ReadLine());

if(x > 0 && y > 0)
{
    Console.WriteLine($"{x}, {y} => 1");
}
if(x < 0 && y > 0)
{
    Console.WriteLine($"{x}, {y} => 2");
}
if(x < 0 && y < 0)
{
    Console.WriteLine($"{x}, {y} => 3");
}
if(x > 0 && y < 0)
{
    Console.WriteLine($"{x}, {y} => 4");
}