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
            int posX = 0;
            int posY = 0;

            while (true)
            {                
                Console.SetCursorPosition(posX, posY);
                Console.Write("#");
                var keyInfo = Console.ReadKey(true);
                switch (keyInfo.KeyChar)
                {
                    case 'a':
                        Console.SetCursorPosition(posX, posY);
                        Console.Write(" ");
                        if (posX > 0)
                        {
                            posX--;
                        }
                        break;
                    case 'w':
                        Console.SetCursorPosition(posX, posY);
                        Console.Write(" ");                        
                        if (posY > 0)
                        {
                            posY--;
                        }
                        break;
                    case 'd':
                        Console.SetCursorPosition(posX, posY);
                        Console.Write(" ");
                        if (posX < 79)
                        {
                            posX++;
                        }
                        break;
                    case 's':
                        Console.SetCursorPosition(posX, posY);
                        Console.Write(" ");
                        if (posY < 25)
                        {
                            posY++;
                        }
                        break;

                }
            }
        }
    }
}
