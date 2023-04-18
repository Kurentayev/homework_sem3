// Задача 23: Напишите программу, которая принимает на вход число 
// (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27 
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int cube = int.Parse(Console.ReadLine() ?? "") ;

Console.Write($"{cube} -> ");

for(int i = 1; i <= cube; i++)
{
    int result = i*i*i;

    Console.Write(result + " ");
}
Console.WriteLine();



// int cube = i * i * i;
// Console.WriteLine(cube);


