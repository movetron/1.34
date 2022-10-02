using System;
public class MainClass
{

    public static void Main(string[] args) {

        string a3 = Console.ReadLine(), a2 = Console.ReadLine(), a1 = Console.ReadLine(), b2 = Console.ReadLine(), b1 = Console.ReadLine();
        string first = a3 + a2 + a1;
        string second = b2 + b1;
        string result = Convert.ToString(Convert.ToInt32(first) + Convert.ToInt32(second));
        char[] number = result.ToCharArray();
        for (int i = 0; i < number.Length; i++)
            Console.Write(number[i] + " ");

    }
}