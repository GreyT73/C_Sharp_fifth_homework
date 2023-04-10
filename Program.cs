void NewTask()
{
    System.Console.WriteLine("Нажмите Enter для продолжения и перехода к следующей задаче");
    Console.ReadLine();
}
System.Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве");
int[] GetArray(int length, int minNumber, int maxNumber)
{
    int[] nums = new int[length];
    Random rand = new Random();
    for(int i = 0; i < nums.Length; i++) nums[i] = rand.Next(minNumber, maxNumber);
    return nums;
}
double[] GetArrayWithFloat(int length, int minNumber, int maxNumber)
{
    double[] nums = new double[length];
    Random  rand = new  Random();
    for (int i = 0; i < nums.Length; i++) nums[i] = rand.NextDouble() * (maxNumber - minNumber) + minNumber;
    return nums;
}
int PrintInfo(string message)
{
    System.Console.WriteLine(message);
    int digit = Convert.ToInt32(Console.ReadLine());
    return digit;
}
void PrintArray(int[] nums)
{
    Console.Write("В массиве: [");
    for (int i = 0; i < nums.Length - 1; i++) System.Console.Write($"{nums[i]}, ");
    Console.Write($"{nums[nums.Length -1]}]");
}
void PrintFloatArray(double[] nums)
{
    Console.Write("В массиве: [");
    for (int i = 0; i < nums.Length - 1; i++) System.Console.Write($"{nums[i]}, ");
    Console.Write($"{nums[nums.Length -1]}]");
}
int len = PrintInfo("Введите длину массива: ");
int[] array = GetArray(len, 100, 1000);
PrintArray(array);
int count = 0;
for (int index = 0; index <array.Length; index++)
{
    if (array[index] % 2 == 0)
    {
        count++;
    }
}
System.Console.WriteLine($"  количество четных чисел: {count}");
NewTask();
System.Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
len = PrintInfo("Введите длину массива: ");
int min = PrintInfo("Введите минимальное значение массива: ");
int max = PrintInfo("Введите максимальное значение массива: ");
array = GetArray(len, min, max);
PrintArray(array);
int countSum = 0;
for (int index = 0; index <array.Length; index++)
{
    if (index % 2 == 1)
    {
        countSum += array[index];
    }
}
System.Console.WriteLine($" сумма нечетных индексов равна {countSum}");
NewTask();
System.Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
len = PrintInfo("Введите длину массива: ");
min = PrintInfo("Введите минимальное значение массива: ");
max = PrintInfo("Введите максимальное значение массива: ");
double[] floatArray = GetArrayWithFloat(len, min, max);
PrintFloatArray(floatArray);
double minimum = floatArray[0];
double maximum = floatArray[0];
for (int index = 1; index <floatArray.Length; index++)
{   
    if (floatArray[index] < minimum)
    {
        minimum = floatArray[index];
    }
    if (floatArray[index] > maximum)
    {
        maximum = floatArray[index];
    }
}
System.Console.WriteLine($" разница между {maximum} и {minimum} составляет {maximum - minimum}");