using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperAINamedAiri2
{
    class Program
    {
        /// <summary>
        ///  f(x) = x*x;
        ///  
        /// f(10) -> 100;
        /// </summary>
        /// <param name="args"></param>

        static ConsoleColor ParinkManSpalva(string tekstas)
        {
            if (tekstas.Contains(":)"))
            {
                return ConsoleColor.Green;                
            }
            else if (tekstas.Contains(":("))
            {
                return ConsoleColor.Red;                
            }
            else
            {
                return ConsoleColor.White;
            }
        }

        static string ParinkSypsenele(string tekstas)
        {
            if (tekstas.Contains(":)"))
            {
                return ":)";
            }
            else if (tekstas.Contains(":("))
            {
                return ":(";
            }
            else
            {
                return "";
            }
        }
        static void Main(string[] args)
        {
            string ivestas_tekstas;
            ivestas_tekstas = "Labas pasauli!!!";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(ivestas_tekstas);
            int kiek_kartu_klausei = 0;
            while (ivestas_tekstas != "iki")
            {                
                ivestas_tekstas = Console.ReadLine();
                ivestas_tekstas = ivestas_tekstas.ToLower();

                Console.ForegroundColor = ParinkManSpalva(ivestas_tekstas);              
                if (ivestas_tekstas.Contains("labas"))
                {
                    Console.WriteLine("Labas, kaip tau sekasi!!!" + ParinkSypsenele(ivestas_tekstas));
                }
                else if (ivestas_tekstas.Contains("iki"))
                {
                    Console.WriteLine("Iki" + ParinkSypsenele(ivestas_tekstas));
                }
                else if (ivestas_tekstas.Contains("tavo vardas"))
                {
                    kiek_kartu_klausei = kiek_kartu_klausei + 1;
                    if (kiek_kartu_klausei == 1)
                    {
                        Console.WriteLine("Mano vardas Airi" + ParinkSypsenele(ivestas_tekstas));
                    }
                    else
                    {
                        Console.WriteLine("Taigi jau klausei" + ParinkSypsenele(ivestas_tekstas));
                    }
                }
                else
                {
                    Console.WriteLine("nesupratau" + ParinkSypsenele(ivestas_tekstas));
                }

            }
            Console.ReadLine();
        }
    }
}
