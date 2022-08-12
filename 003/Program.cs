// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


class Program
{
    static void WriteSelect(string[] namesArray)
    {
        for (int i = 0; i < namesArray.Length - 1; i++)
        {
            Console.Write(i + 1 + " - " + namesArray[i] + ", ");
        }
        Console.WriteLine(namesArray.Length + " - " + namesArray[namesArray.Length - 1] + ".");
    }
    static void SelectDay()
    {
        string[] namesDay = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
        WriteSelect(namesDay);
        Console.WriteLine("Укажите цифру, обозначающую день недели ");
        int indexDay = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("День недели " + namesDay[indexDay - 1]);
        if (indexDay > 5)
        {
            Console.WriteLine("Этот день является выходным? ");
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Этот день является выходным? ");
            Console.WriteLine("Нет");
        }
    }
    static void Main(string[] args)
    {
        SelectDay();
    }
}
