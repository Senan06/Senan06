using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            string ay = "cdzxfvzxcvg";
            if (ay == "Yanvar" || ay == "Fevral" || ay == "Dekabr")Console.WriteLine("Winter");
            else if (ay == "Mart" || ay == "Aprel" || ay == "May") Console.WriteLine("Spring");
            else if (ay == "Iyun" || ay == "Iyul" || ay == "Avqust") Console.WriteLine("Summer");
            else if (ay == "Sentyabr" || ay == "Oktyabr" || ay == "Noyabr") Console.WriteLine("Autumn");
            else Console.WriteLine("Not 404 Found");
        }
    }
}
