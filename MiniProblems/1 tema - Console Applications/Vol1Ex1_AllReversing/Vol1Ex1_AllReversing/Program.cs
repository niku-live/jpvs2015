using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vol1Ex1_AllReversing
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string text = Console.ReadLine();
                text = new String(text.Reverse().ToArray());
                Console.WriteLine(text);
            }
        }
    }
}
