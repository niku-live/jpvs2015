using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vol1Ex3_MovingSymbol
{    
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character(0, 0, '#');
            while (true)
            {                
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                switch (keyInfo.KeyChar)
                {
                    case 'a':
                        character.Move(-1, 0);
                        break;
                    case 'w':
                        character.Move(0, -1);
                        break;
                    case 'd':
                        character.Move(1, 0);
                        break;
                    case 's':
                        character.Move(0, 1);
                        break;

                }
            }
        }
    }
}
