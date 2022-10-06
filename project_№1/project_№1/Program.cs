using System;
public class MainClass
{

    public static void Main(string[] args) {

        double a, b;
        Console.WriteLine("Введите A:");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите B:");
        b = Convert.ToInt32(Console.ReadLine());

        if (a != 0) { 
            Console.WriteLine("Корень x = {0}", -b / a);
        }
        else
        { 
                Console.WriteLine("Нет решения");
        }

    }
}