using System;

namespace Week7Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menu = { "olett", "pannkoogid", "keedumuna", "neljaviljapuder", "singivõileib" };
            Console.WriteLine($"Meie menüüs on {menu.Length} valikut");

            menu[4] = "juustuvõileib";
            menu[3] = "kaerapuder";
            
            Console.WriteLine("Tänases menüüs on:");


            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine(menu[i]);
            }

            Console.WriteLine("Vali toit (sisesta number 1 - 5:");
            int userChoice = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine($"Oled valinud {menu[userChoice]}");

        }
    }
}
