// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.Write("Input some numbers with using a space and press enter: ");

int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) count++;
}

Console.WriteLine($"Entered {count} numbers that are greater than 0.");
*/

// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Input b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = -(b1 - b2) / (k1 - k2);
double y = k2 * x + b2;

x = Math.Round(x, 2);
y = Math.Round(y, 2);

Console.WriteLine($"The lines will intersect at the point with the coordinates {x};{y}.");
