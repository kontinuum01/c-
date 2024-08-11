/ Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

int[] numbers = { 1, -5, 6, 6, 3, 9, -7, 4, 2, 5, 1, 2 };

foreach (int number in numbers)
{
Console.Write(number + "\t");
}
System.Console.WriteLine();

int[] multPairs = new int[numbers.Length / 2];

// for (int i = 0; i < multPairs.Length; i++)
// {
// multPairs[i] = numbers[i] * numbers[numbers.Length - 1 - i];
// }

for (int i = 0, j = numbers.Length - 1; i < multPairs.Length; i++, j--)
{
multPairs[i] = numbers[i] * numbers[j];
}

foreach (int pair in multPairs)
{
Console.Write(pair + "\t");
}