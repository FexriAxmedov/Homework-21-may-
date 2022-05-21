using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 2) Istifadəçidən alınacaq iki ədəd   arasındadakı ədədlərin  ortlamasını tapan və bu ortalamanı ekrana yazdıran
                C# kodunu yazınız
            */
            Console.Write("1-ci ededi daxil edin: ");
            string a = Console.ReadLine();
            Console.Write("2-ci ededi daxil edin: ");
            string b = Console.ReadLine();

            int number1 = Convert.ToInt32(a);

            int number2 = Convert.ToInt32(b);

            int sum;

            sum = number1 + number2;
            sum /= 2;
            Console.WriteLine("Ədədlərin  ortlaması: " + sum);
        }
    }
}
