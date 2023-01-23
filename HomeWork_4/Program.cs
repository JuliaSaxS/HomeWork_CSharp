// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
Console.Write("Input a number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number B: ");
int b = Convert.ToInt32(Console.ReadLine());
int count = a;
for (int i = 1; i < b; i++) count = count * a;
Console.WriteLine($"{a} to the degree of {b} is equal to " + count);
*/
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
Console.Write("Input a number: ");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (i > 0)
{
    int num = i % 10;
    i = i / 10;
    sum = sum + num;
}
Console.WriteLine("The sum of all digits of the entered number is equal to " + sum);
*/
// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
//Метод создания массива:
int[] CrateArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, size + 1);
    }
    return array;
}
//Метод вывода массива:
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();    
}
//Программа:
Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] newArray = CrateArray(length);
ShowArray(newArray);
*/
