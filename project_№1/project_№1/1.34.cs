using System;
public class Mainclass
{

public static void Main(string[] args)
{
    double a, b;
    Console.WriteLine("Введите A для линейного уравнения ax + b = 0");
    a = Convert.ToInt32(Console.ReadLine());
      
    Console.WriteLine("Введите B для линейного уравнения ax + b = 0");
    b = Convert.ToInt32(Console.ReadLine());

    if (a != 0)
    {

        Console.WriteLine("Корень x = {0}", -b / a);

    }
    else
    {

        Console.WriteLine("Нет решения");
    }

}
}
