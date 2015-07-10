using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * {2x{Du gaideliai} + {Baltus zirnius kule}} + {2x{Dvi visteles} + {I maluna veze}}
 * yra interface'as Eiliuotas
 * Eiliuotas turi metoda Print()
 * 
 * Reikia parasyt 3 klases:
 * Eilute - paprastas String
 * Jungtinis - du sujungti objektas
 * Kartotinis - i kartu pasikartojantis objectas
 * 
 * ir sukomponuoti objekta taip, kad paskutinio 
 * objekto Print() metodas atspausdintu eilerasti
 * 
*/


namespace uzd1
{

    interface Eiliuotas
    {
        void Print();
    }

    class Eilute : Eiliuotas
    {
        private String text;


        public Eilute(String text)
        {
            this.text = text;
        }

        public void Print()
        {
            Console.WriteLine(text);
        }
    }

    class Jungtinis : Eiliuotas
    {
        Eiliuotas pirmas;
        Eiliuotas antras;

        public Jungtinis(Eiliuotas pirmas, Eiliuotas antras)
        {
            this.pirmas = pirmas;
            this.antras = antras;
        }

        public void Print()
        {
            pirmas.Print();
            antras.Print();
        }
    }

    class Kartotinis : Eiliuotas
    {
        int kiekis;
        Eiliuotas eilute;

        public Kartotinis(Eiliuotas eilute, int kiekis)
        {
            this.eilute = eilute;
            this.kiekis = kiekis;
        }

        public void Print()
        {
            for (int i = 0; i < kiekis; i++)
            {
                eilute.Print();
            }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Eilute a = new Eilute("Du gaideliai");
            Eilute b = new Eilute("Baltus zirnius kule");
            Eilute c = new Eilute("Dvi visteles");
            Eilute d = new Eilute("I maluna veze");

            Kartotinis ka = new Kartotinis(a, 2);
            Kartotinis kc = new Kartotinis(c, 2);

            Jungtinis j1 = new Jungtinis(ka, b);
            Jungtinis j2 = new Jungtinis(kc, d);

            Eiliuotas eilerastis = new Jungtinis(j1, j2);

            eilerastis.Print();

            Console.ReadKey();
        }
    }
}
