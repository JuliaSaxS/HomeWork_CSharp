// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
void CrateRandomArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}

void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.Write("Input a length of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[size];
CrateRandomArray(numbers);
Console.Write("Array: ");
PrintArray(numbers);

int count = 0;

for (int num = 0; num < numbers.Length; num++)
if (numbers[num] % 2 == 0) count++;

Console.WriteLine($"Total {numbers.Length} numbers in the array. {count} of them are even.");
*/
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
void CrateRandomArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(-100,100);
        }
}

void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

Console.Write("Input a length of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[size];
CrateRandomArray(numbers);
Console.Write("Array: ");
PrintArray(numbers);

int sum = 0;
for (int num = 0; num < numbers.Length; num+=2) sum = sum + numbers[num];

    Console.WriteLine($"Total {numbers.Length} numbers in the array, the sum of the elements standing in odd positions is equal to {sum}.");
*/
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void CrateArray(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}

void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

Console.Write("Input a length of array: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] numbers = new double[size];
CrateArray(numbers);
Console.WriteLine("Array: ");
PrintArray(numbers);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int num = 0; num < numbers.Length; num++)
{
    if (numbers[num] > max) max = numbers[num];
    if (numbers[num] < min) min = numbers[num];   
}

Console.WriteLine($"Total {numbers.Length} numbers in the array. The maximum value is {max}, the minimum value is {min}.");
Console.WriteLine($"{max} - {min} = {max - min}.");