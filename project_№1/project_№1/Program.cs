using System;
public class MainClass
{

    public static void Main(string[] args)
    {

        Console.Write("часы: "); // 0 <= часы <= 11
        int h = Convert.ToInt32(Console.ReadLine());

        Console.Write("минуты: "); // 0 <= минуты <= 59
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("секунды: "); // 0 <= секунды <= 59
        int s = Convert.ToInt32(Console.ReadLine());

        int sum = (h * 3600) + (m * 60) + s;
        int corner = (sum / 10) % 360;

        Console.WriteLine("Угол стрелки часов = " + corner);


    }
}
