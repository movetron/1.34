using System;

public class Mainclass
{

public static void Main(string[] args)
{

        Console.Write("Введите цифры первого числа: ");
        int a3 = Convert.ToInt32(Console.ReadLine());
        int a2 = Convert.ToInt32(Console.ReadLine());
        int a1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите цифры второго числа: ");
        int b2 = Convert.ToInt32(Console.ReadLine());
        int b1 = Convert.ToInt32(Console.ReadLine());

        int c3 = ((a3 * 100) + (a2 * 10) + (b2 * 10) + a1 + b1) / 100;
        int c2 = (((a3 * 100) + (a2 * 10) + (b2 * 10) + a1 + b1) - c3 * 100) / 10;
        int c1 = (((a3 * 100) + (a2 * 10) + (b2 * 10) + a1 + b1) - c3 * 100) - c2 * 10;
        Console.WriteLine("Цифры числа " + ((a3 * 100) + (a2 * 10) + (b2 * 10) + a1 + b1) + ": " + c3 + ";" + c2 + ";" + c1 + ", равного сумме чисел: " + a3 + a2 + a1 + " и " + b2 + b1);

    }
}
