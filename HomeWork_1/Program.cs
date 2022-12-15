// Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine(num1 + " is a bigger number.");
    Console.WriteLine(num2 + " is a smaller number.");
}
else
{
    Console.WriteLine(num2 + " is a bigger number.");
    Console.WriteLine(num1 + " is a smaller number.");
}
*/

// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
/*
Console.Write("Input the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = 0;

if(num1 > num2)
    max = num1;
else
    max = num2;
if(num2 > num3)
    max = num2;
else
    max = num3;
if(num1 > num3)
    max = num1;

Console.WriteLine(max + " is a bigger number.");
*/
//Напишите программу, которая на вход принимает число 
//и выдаёт, является ли число чётным (делится ли оно 
//на два без остатка).
/*
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int div = number % 2;

if(div == 0)
{
    Console.WriteLine("Yes, the number is even.");
}
else
{
    Console.WriteLine("No, the number is odd.");
}
*/

// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 1;

while(current <= number)

    {  
    if(current % 2 == 0)    
        Console.Write(current + " ");
        current++;
    }
    

        
    