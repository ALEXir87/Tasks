Console.WriteLine("Задача№13");
Console.WriteLine("Введи число N:");
int N = Convert.ToInt32(Console.ReadLine());
N = Math.Abs(N);
if(N < 100)
{
Console.WriteLine("Третьей цифры числа N нет");
}
else
{
    while(N >= 999)
    {
        N = N / 10;  
    }
Console.WriteLine($"Третья цифра числа N = {N % 10}");  
}