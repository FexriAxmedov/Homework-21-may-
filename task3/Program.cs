using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {

            
                Console.WriteLine("yasinizi daxil edin");
                byte a = Convert.ToByte(Console.ReadLine());
                if (a < 18)
                {
                    Console.WriteLine("yasiniz 18 den asagidir");
                }
                else
                {
                    Console.WriteLine("balinizi daxil edin");
                    int b = int.Parse(Console.ReadLine());
                    if (b < 50)
                    {
                        Console.WriteLine("baliniz 50den asagidir");
                    
                    }
                    else
                    {
                        Console.WriteLine("Tebrikler.Siz ugurla kecdiniz");
                        Console.WriteLine("yasinizi daxil edin");
                    }
                }
            
        }
    }
}

