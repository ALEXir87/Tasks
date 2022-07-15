Console.WriteLine("Задача№10");
Console.WriteLine("Введи трёхзначное число N:");
int N = Convert.ToInt32(Console.ReadLine());
int digital1 = N / 100;
int digital2 = N / 10 % 10;
int digital3 = N % 10;
Console.WriteLine($"Вторая цифра числа N = {digital2}");