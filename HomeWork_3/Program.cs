// Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом.
/*
void CutNumber(int number)
{
    int x = 0;
    if(number >= 10 && number <= 99)
            if(x == number / 10 - number % 10) Console.Write($"The number {number} is a palindrome.");  
            else Console.Write($"The number {number} isn't a palindrome.");
    else if(number >= 100 && number <= 999) 
            if(x == number / 100 - number % 10) Console.Write($"The number {number} is a palindrome.");
            else Console.Write($"The number {number} isn't a palindrome.");
    else if(number >= 1000 && number <= 9999) 
            if(x == number / 100 - (number % 10 * 10 + number % 100 / 10)) Console.Write($"The number {number} is a palindrome.");
            else Console.Write($"The number {number} isn't a palindrome.");
    else if(number >= 10000 && number <= 99999) 
            if(x == number / 1000 - (number % 10 * 10 + number % 100 / 10)) Console.Write($"The number {number} is a palindrome.");
            else Console.Write($"The number {number} isn't a palindrome.");
    else if(number >= 100000 && number <= 999999) 
            if(x == number / 1000 - (number % 10 * 100 + (number % 100 - number % 10) + number % 1000 / 100)) Console.Write($"The number {number} is a palindrome.");
            else Console.Write($"The number {number} isn't a palindrome.");
    else if(number >= 1000000 && number <= 9999999) 
            if(x == number / 10000 - (number % 10 * 100 + (number % 100 - number % 10) + number % 1000 / 100)) Console.Write($"The number {number} is a palindrome.");
            else Console.Write($"The number {number} isn't a palindrome.");
    else if(number >= 10000000 && number <= 99999999) 
            if(x == number / 10000 - (number % 10 * 1000 + (number % 100 - number % 10) * 10 + (number % 1000 - number % 100) / 10 + number % 10000 / 1000)) Console.Write($"The number {number} is a palindrome.");
            else Console.Write($"The number {number} isn't a palindrome.");
    else if(number >= 100000000 && number <= 999999999) 
            if(x == number / 100000 - (number % 10 * 1000 + (number % 100 - number % 10) * 10 + (number % 1000 - number % 100) / 10 + number % 10000 / 1000)) Console.Write($"The number {number} is a palindrome.");
            else Console.Write($"The number {number} isn't a palindrome.");
}
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
CutNumber(number);
*/
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double TwoPoints(double xPos1, double yPos1, double zPos1, double xPos2, double yPos2, double zPos2)
{
    return Math.Sqrt(Math.Pow(xPos1 - xPos2, 2) + Math.Pow(yPos1 - yPos2, 2) + Math.Pow(zPos1 - zPos2, 2));
}

Console.Write("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(TwoPoints(x1, y1, z1, x2, y2, z2));



// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void CubeNum (int num)
{
    int current = 1;
    while (current <= num)
        {
            Math.Pow(current, 3);
            Console.Write($"{Math.Pow(current, 3)}, ");
            current++;
        }
}
Console.Write("Input a number: ");
int x = Convert.ToInt32(Console.ReadLine());

CubeNum(x);
*/