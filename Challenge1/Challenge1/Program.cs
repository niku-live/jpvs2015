using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    enum AccentType
    {
        Normal,
        Happy,
        Angry,
        Hm
    }

    class Program
    {
        private static void PrintText(string text, AccentType accType)
        {
           switch (accType)
           {
               case AccentType.Normal: Console.ForegroundColor = ConsoleColor.White;
                   break;
               case AccentType.Angry: Console.ForegroundColor = ConsoleColor.Red;
                   break;
               case AccentType.Happy: Console.ForegroundColor = ConsoleColor.Green;
                   break;
               case AccentType.Hm: Console.ForegroundColor = ConsoleColor.DarkYellow;
                   break;
           }
           Console.WriteLine(text);
        }

        private static AccentType GetAccentType(string answer)
        {
            var result = AccentType.Normal;
            if (answer.Contains(":)"))
            {
                result = AccentType.Happy;
            }
            if (answer.Contains(":("))
            {
                result = AccentType.Angry;
            }
            if (answer.Contains(":O"))
            {
                result = AccentType.Hm;
            }
            if (result == AccentType.Happy)
            {
                myCurrType = result;
            }
            else if (result != AccentType.Angry)
            {
                myCurrType = result;
            }
            return result;
        }

        static AccentType myCurrType = AccentType.Normal;

        private static string GetAnswer(string question)
        {
            var text = question.ToLower();
            if (text.Contains("tavo vardas"))
            {
                return "Mano vardas yra Airi";
            }
            if (text.Contains("labas"))
            {                
                return "Labas";
            }
            if (text.Contains("kas tu"))
            {
                return "Na aš tiesiog eilinė asmenybė, o kas tu?";
            }
            return "Nesupratau, gal galėtum paaiškinti";
        }


        static void Main(string[] args)
        {
            PrintText("Hello World!!!", AccentType.Angry);
            while (true)
            {
                var text = Console.ReadLine();
                var answer = GetAnswer(text);
                PrintText(answer, GetAccentType(answer));
            }
            Console.ReadLine();
        }
    }
}
