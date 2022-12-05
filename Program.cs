/*
Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

/*
Console.WriteLine("Дружочек, введи пятизначное положительно число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 10000 || number > 99999)
{
    Console.WriteLine($"Введи И пятизначное, И положительно число, а не вот это вот: {number}!");
    Console.Write("Вводи давай, не стесняйся: ");
    number = Convert.ToInt32(Console.ReadLine());
}

int lastDigit = number % 10;
number = number / 10;
int fourthDigit = number % 10;
number = number / 100;
int secondDigit = number % 10;
int firstDigit = number / 10;

if (lastDigit == firstDigit && fourthDigit == secondDigit) Console.WriteLine("Ах тыж красавчик, полиндромчик замутил))");
else Console.WriteLine("А не хочешь побаловаться палиндромчиком, а не этим непонятным числом?))");
*/


/*
Задача 21: Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

/*
Console.WriteLine("Введите координату x1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z1");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату x2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z2");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2)+ Math.Pow(z2-z1, 2));

Console.WriteLine($"Расстояние между точками в 3D пространстве равно: {Math.Round(result, 2)}");
*/

/*
Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9. 
5 -> 1, 8, 27, 64, 125
*/

/*
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

while (n <= 0)
{
    Console.WriteLine("Введите положительное число больше нуля: ");
    n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Ряд кубов чисел от 1 до {n} выглядит так: ");

for (int i = 1; i <= n; i++)
{
    Console.Write(Math.Pow(i, 3) + " ");
}
*/


