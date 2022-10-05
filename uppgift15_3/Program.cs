using System;

namespace Uppgift3_15
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hur många timmar har du tänkt hyra bilen?");
            Console.WriteLine("Du kan max hyra för 950kr/dag och det kostar 80kr/timme");

            int timmar = int.Parse(Console.ReadLine());

            int pris = timmar * 80;

            if (pris < 950)
            {
                Console.WriteLine("Det kommer kosta dig " + pris + "kr");
            }

            else
            {
                Console.WriteLine("Du har uppnått den maximala hyran på en dag, kom tillbaka någon annan dag");
            }


        }
    }
}