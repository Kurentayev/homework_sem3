// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



int a1 = GetUserNumber("Введите значение x1: ");
int b1 = GetUserNumber("Введите значение y1: ");
int z1 = GetUserNumber("Введите значение z1: ");

int a2 = GetUserNumber("Введите значение x2: ");
int b2 = GetUserNumber("Введите значение y2: ");
int z2 = GetUserNumber("Введите значение z2: ");

double result = Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"A ({a1},{b1},{z1}); B ({a2},{b2},{z2}) -> {result:f2}");

static int GetUserNumber(string message)
{
     while (true)
     {
         Console.Write(message);
         int userInput;
         if (int.TryParse(Console.ReadLine(), out userInput))
         {
             return userInput;
         }
         else Console.WriteLine("Вы ввели некорректные данные ");
     }
}