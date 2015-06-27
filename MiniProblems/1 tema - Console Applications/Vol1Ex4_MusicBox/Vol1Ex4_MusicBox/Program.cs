using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vol1Ex4_MusicBox
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey(true);
                switch (info.KeyChar)
                {
                    case 'a':
                        Console.Beep(440, 200);
                        break;
                    case 's':
                        Console.Beep(500, 200);
                        break;
                    case 'd':
                        Console.Beep(580, 200);
                        break;
                    case 'f':
                        Console.Beep(660, 200);
                        break;
                    case 'g':
                        Console.Beep(740, 200);
                        break;
                    case 'h':
                        Console.Beep(820, 200);
                        break;
                    case 'j':
                        Console.Beep(900, 200);
                        break;
                    case 'k':
                        Console.Beep(980, 200);
                        break;
                    case 'l':
                        Console.Beep(1060, 200);
                        break;

                }
            }
        }
    }
}
