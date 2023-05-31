using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    internal class Run
    {
        static void Main(string[] args)
        {
            //hp shield atk mana gold 
            int[] character = { 200, 0, 10, 100, 20 };
            int sheep_count = 0;

            int Maxhp = character[0];
            string[] atacks = { "shield", "combo", "wilk" };

            while (Character.zywot(character))
            {
                Informations.rounds(character, sheep_count);
                string inp = Console.ReadLine().ToLower();
                switch (inp)
                {
                    case "1":
                        Console.WriteLine("Napotykasz owce");
                        Fighto.Walka(character);
                        sheep_count++;
                        break;
                    case "2":
                        Atakos.Ataki_info();
                        break;

                }
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("  Umarłeś, no cóż");
            Console.WriteLine("---------------------");
            Console.ReadKey();
        }
    }
}
