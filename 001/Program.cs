// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1


class Program
{
        static void Main(string[] args)
    {
        Console.WriteLine("Введите трехзначное число ");
        int numbers = Convert.ToInt32(Console.ReadLine());
        int n1 = numbers/100;
        int n2 = (numbers % 100) /10;
        int n3 = numbers % 10;
        Console.WriteLine("вторая цифра этого числа = ");
        Console.WriteLine(n2);
    }
}




