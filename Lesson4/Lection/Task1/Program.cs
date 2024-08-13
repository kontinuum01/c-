//Вычислить значение формулы a*b/c+d. Решение оформить в виде функции

//Метод
double CalculateFormula(int a, int b, int c, int d) 
{
    double numenator = a * b;
    int domenator = c + d;
    double result = numenator / domenator;
    return result;
}
//Вызов метода(функции) с передаваемыми аргументами
double result = CalculateFormula(1, 2,, 3, 4);
Console.WriteLine("Hello, World!");
