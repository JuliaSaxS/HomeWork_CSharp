// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNumbers(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        ShowNumbers(n, count + 1);
        Console.Write(count + " ");
    }
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int num = InputNumbers("Input a number: ");
int count = 1;
ShowNumbers(num, count);
if (num < 0 ) Console.Write("Input error.");
*/
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int m = InputNumbers("Input the number M: ");
int n = InputNumbers("Input the number N: ");
int temp = m;

if (m > n) 
{
    m = n; 
    n = temp;
}
ShowSum(m, n, temp = 0);

void ShowSum(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($"The sum of the elements in the range from M to N is equal to {sum}.");
        return;
    }
    ShowSum(m, n - 1, sum);   
}

int InputNumbers(string input) 
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.




