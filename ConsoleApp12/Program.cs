using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            //1)  Istifadəçidən alınacaq iki ədəd arasinda ədədlərin toplamını ekranda göstərəcək C# kodunu yazınız
            Console.Write("1-ci ededi daxil edin: ");
            string a = Console.ReadLine();
            Console.Write("2-ci ededi daxil edin: ");
            string b = Console.ReadLine();

            int number1 = Convert.ToInt32(a);

            int number2 = Convert.ToInt32(b);

            int sum;

            sum = number1 + number2;
            Console.WriteLine("Ededlerin cemi: " + sum);
        }
    }
}
