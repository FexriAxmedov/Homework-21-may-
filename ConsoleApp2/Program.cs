using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
        //4)Istifadəçidən alınacaq iki ədəd arasındakı  tək ədədlərin cəmini tapan və bu cəmi ekranda göstərən
        yuxari:
            Console.Write("1-ci ededi daxil edin: ");
            string a = Console.ReadLine();
            Console.Write("2-ci ededi daxil edin: ");
            string b = Console.ReadLine();
            int sum;
            int number1 = Convert.ToInt32(a);

            int number2 = Convert.ToInt32(b);

            if (number1 % 2 != 0 && number2 % 2 != 0)
            {
                sum = number1 + number2;
                Console.WriteLine("Tek ededlerin cemi: " + sum);
            }
            else
            {
                Console.WriteLine("Gonderdiyiviz eded tek deyil!! Yeniden cehd edin.... ");
                goto yuxari;
            }

        }
    }
}
