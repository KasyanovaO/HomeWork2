// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число ");
        string numbers = Console.ReadLine();
        Console.WriteLine("третья цифра этого числа = ");
        Console.WriteLine($"{numbers[2]}");
    }
}
