using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperAINamedAiri
{
    class Program
    {
        /// f(x) = x * x;
        /// f(2) -> 4
        /// 
        /// 
        /// 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>



        static Tuple<string, ConsoleColor> Nuotaika(string tikrinimui)
        {
            if (tikrinimui.Contains(":)"))
            {
                return new Tuple<string,ConsoleColor>(":)", ConsoleColor.Green);
            }
            else if (tikrinimui.Contains(":("))
            {
                return new Tuple<string,ConsoleColor>(":(", ConsoleColor.Red);
            }

            return new Tuple<string,ConsoleColor>("", ConsoleColor.White);
        }

        static void Main(string[] args)
        {
            System.IO.FileInfo finfo = new System.IO.FileInfo("C:\\Stovyklai\\airi.txt");
            int kiek_kartu_klausei_kas_tu = 0;
            string ivestas_tekstas;
            ivestas_tekstas = "Labas, pasauli!!!";
            var reader = finfo.OpenText();
            var issaugotas_tekstas = reader.ReadLine();
            reader.Close();            
            var rez = Nuotaika(issaugotas_tekstas);
            Tuple<string, ConsoleColor> buvusi_nuotaika = rez;
            while (!ivestas_tekstas.Contains("iki"))
            {                
                ivestas_tekstas = Console.ReadLine();
                ivestas_tekstas = ivestas_tekstas.ToLower();
                buvusi_nuotaika = rez;
                rez = Nuotaika(ivestas_tekstas);

                if (buvusi_nuotaika.Item1 == ":(")
                {
                    if (rez.Item1 != ":)")
                    {
                        rez = buvusi_nuotaika;
                    }
                }
                
                Console.ForegroundColor = rez.Item2;
                if (ivestas_tekstas.Contains("labas"))
                {
                    Console.WriteLine("O labas, kaip sekasi?" + rez.Item1);
                }                
                else if (ivestas_tekstas.Contains("kas tu"))
                {

                    kiek_kartu_klausei_kas_tu = kiek_kartu_klausei_kas_tu + 1;
                    if (kiek_kartu_klausei_kas_tu == 1)
                    {
                        Console.WriteLine("As Airi" + rez.Item1);
                    }
                    else
                    {
                        Console.WriteLine("Taigi jau klausei, kiek gi kartu galiu kartoti." + rez.Item1);
                    }
                }
                else if (ivestas_tekstas.Contains("iki"))
                {
                    Console.WriteLine("Iki" + rez.Item1);
                }
                else
                {
                    Console.WriteLine("Nesupratau, gal gali pakartoti" + rez.Item1);

                }

                Console.WriteLine(String.Format("{0}", ivestas_tekstas));


            }
            
            var writer = finfo.CreateText();
            writer.WriteLine(rez.Item1);
            writer.Close();
            Console.ReadLine();
        }
    }
}
