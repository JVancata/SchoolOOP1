using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Opelka opelka = new Opelka("Opelka", "Popelka");
            //Opelka opelka = new Opelka();
            //Console.WriteLine(opelka.Jmeno);
            //opelka.Jmeno = "Opelka";
            Console.Write("Zadej jméno svého opelky: ");
            opelka.Jmeno = Console.ReadLine();

            Console.Write("\nZadej příjmení svého opelky: ");
            Console.ReadLine();
            Console.WriteLine("\nSajkkkk, opelkové nemaj příjmení, hlupáku.\n");

            Console.WriteLine("Ahoj {0}. Jak se máš? \n{0}: Já se mám skvěle. A taky smrdím. \nJaké je tvé jméno? \n{0}: No přece {0} \nA křestní? \n{0}: Nemám, hlupáku.", opelka.Jmeno);

            Console.Write("\nZadej jméno jeho oblíbené okurky: ");
            opelka.OblibenaOkurka = Console.ReadLine();

            Console.WriteLine("\nAaaah, taky mám rád {0}", opelka.OblibenaOkurka);

            Console.Write("\nMá {0} co má rád {1} psa?: ",opelka.Jmeno, opelka.OblibenaOkurka);
            string hasPes = Console.ReadLine().ToLower();
            //hasPes = hasPes.ToLower();
            List<String> moznostiNaAno = new List<string>()
            {
                "jo", "ano", "jj", "j", "ne asi", "ma", "mam", "jasne", "neasi", "ma vole", "dva", "yes", "jes", "yez", "jez", "joo", "jooo", "jsem pes", "jo to jsem já", "jsem pes", "haf", "štěk", "stek", "jo má", "ty vole brachu jasná páka"
            };
            if (moznostiNaAno.Contains(hasPes))
	        {
                Console.WriteLine("\nNajs");
                Console.WriteLine("Tak teď ho hezky zapíšeš, je to jasný?");
                Console.WriteLine("To nebyla otázka, lol, zapíšeš");
                Console.Write("\n Zapiš: ");
            }
            else
            {
                Console.WriteLine("\nTak to je blby, kup mu psa");
            }
            Console.WriteLine("Tak teď ho hezky zapíšeš, je to jasný?");

            /*if (hasPes == "jo" || hasPes == "ano" || hasPes == "jj" || hasPes == "j" || hasPes == "j" || hasPes == "ne asi" || hasPes == "ma" || hasPes == "mam")
            {

            }
            else
            {
                Console
            }*/

        }
    }
}
