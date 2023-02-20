// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void ShowArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}

Console.Write("Enter the number of array elements: ");
int size  = Convert.ToInt32(Console.ReadLine());

string[] array = new string[size];

for (int i = 0; i < size; i++)
{
	Console.Write($"Enter the {i+1} element: ");
    string result = Console.ReadLine();
	array[i] = result;
}
Console.WriteLine();
Console.Write("The entered array: ");
ShowArray(array);

int count = 0;
for (int i = 0; i < array.Length; i++)
	if(array[i].Length <= 3) count++;

string[] array2 = new string[count];
int j = 0;
for (int i = 0; i < array.Length; i++)
    if (array[i].Length <= 3) 
    {
        array2[j] = array[i];
        j++;
    }
Console.WriteLine();
Console.Write("The resulting array: ");
ShowArray(array2);
