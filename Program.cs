// /* Проверка на полиандром
// 12345 -> 54321
// 12345 % 10 = 5
// 12345 / 10 = 1234
// 1234 % 10 = 4
// 5 * 10 + 4 = 54
// 1234 / 10 = 123
// 123 % 10 = 3
// 54 * 10 + 3 = 543
// 123 / 10 = 12
// 12 % 10 = 2
// 543 * 10 + 2 = 5432
// 12 / 10 = 1
// 1 % 10 = 1
// 5432 * 10 + 1 = 54321
// */

// long InputNum(string message)
// {
// Console.Write(message);
// return long.Parse(Console.ReadLine()!);
// }

// long ReverseNum(long number)
// {
// long reversedNum = 0;
// while (number != 0)
// {
// reversedNum = reversedNum * 10 + number % 10;
// number /= 10;
// }
// return reversedNum;
// }

// bool Palindrome(long num, long rev)
// {
// return num == rev;
// }

// long num = InputNum("Введите число: ");
// long rev = ReverseNum(num);
// bool res = Palindrome(num, rev);
// Console.WriteLine(res);

// // Подсчет числа разрядов 

// int InputNum(string message)
// {
// Console.Write(message);
// return int.Parse(Console.ReadLine()!);
// }
// int Number(int num)
// {
// int res = 0;
// while(num != 0)
// {
// num /= 10;
// res++;
// }
// return res;
// }

// int number = InputNum(" Введите целое число: ");
// int result = Number(number);
// Console.Write(" Количество цифр в числе: " + result);

// // Нахождение факториала

// int InputNum(string message)
// {
// Console.Write(message);
// return int.Parse(Console.ReadLine()!);
// }

// int Factorial(int num)
// {
// int count = 1;
// for (int i = 1; i <= num; i++) count *= i;
// return count;
// }
// int num = InputNum("Введите целое число: ");
// int res = Factorial(num);
// Console.WriteLine($"Факториал числа равен: {res}");

// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int InputNum(string message)
{
Console.WriteLine(message);
return int.Parse(Console.ReadLine()!);
}
int[] ArrayRand(int size)
{
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
array[i] = new Random().Next(2);
}
return array;
}
void PrintArray(int[] array)
{
int size = array.Length;
for (int i = 0; i < size; i++)
{
Console.Write(array[i]+" ");
}
}
int len = InputNum("Введите длину массива: ");
int[] arr = ArrayRand(len);
PrintArray(arr);