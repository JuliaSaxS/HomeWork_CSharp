// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int CutNumber(int num)
{
    if(num >= 100 && num <= 999) return num / 10 % 10;
    else
        return -1;
}

Console.Write("Enter a three digit number: ");

int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{CutNumber(num)}");
*/

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int CutNumber(int number)
{
    if (number >=100)
    {
        while (number > 999)
            {
                number = number / 10;
            }
        int result = number % 10;
        return result; 
    }
    else
    {
        return -1;
    }
}

Console.Write("Enter a number: ");

int number = Convert.ToInt32(Console.ReadLine());

if(CutNumber(number) == -1)
    
    Console.WriteLine("There is no third digit.");

else
    
    Console.WriteLine($"Third digit is {CutNumber(number)}.");
*/

//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool WeekDay(int num)
{
    if(num == 6 || num == 7) return true;
    else return false;
}

Console.Write("Enter a number indicating the day of the week: ");

int num = Convert.ToInt32(Console.ReadLine());

if(WeekDay(num) == false)
    
    Console.WriteLine($"No, {num} is not a weekend.");

else
    
    Console.WriteLine($"Yes, {num} is a weekend.");
