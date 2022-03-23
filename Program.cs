using System;

namespace Add_1_to_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pgorgam dodaje do siebie kolejne liczby");
            int a = 0;
            int i;
            try
            {
                for (i = 0; i <= 100; i++)
                {
                    a += i;   //a = a + i;
                }
               Console.WriteLine("Wynik dodawania od 0 do 100 wynosi: {0}", a);
            }
            catch (Exception)
            {

                Console.WriteLine("Podałeś złą zmienną."); 
            }
        }
    }
}
