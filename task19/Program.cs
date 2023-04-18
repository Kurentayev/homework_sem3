// Задача 19: Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Введите пятизначное число: ");

int number = int.Parse(Console.ReadLine());

int a = number / 1000 % 10;
int b = number / 10 % 10;

int c = number / 10000;
int e = number % 10;

if(a==b&&c==e)
{
    Console.WriteLine($"{number} -> да");
}
else
{
     Console.WriteLine($"{number} -> нет");
}
