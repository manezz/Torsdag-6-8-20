using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torsdag_6_8_20
{
    class Program
    {
        static void Main(string[] args)
        {
            string tvkant = "\x250C";
            string thkant = "\x2510";
            string bvkant = "\x2514";
            string bhkant = "\x2518";

            string vside = "\x2502";
            string hside = "\x2502";
            string top = "\x2500";
            string bund = "\x2500";

            string vaMid = "\x2500";
            string loMid = "\x2502";

            Console.WriteLine("Hvor stor skal breden være?");
            Console.WriteLine("");
            
            int brede = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Hvor stor skal lengden være");
            Console.WriteLine("");

            int lengde = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            for (int i = 1; i < brede; i++)
            {
                Console.SetCursorPosition(i + 30, 8);
                Console.Write(top);

                Console.SetCursorPosition(i + 30, 8 + lengde);
                Console.Write(bund);

                Console.SetCursorPosition(i + 30, 8 + lengde / 2);
                Console.Write(vaMid);
            }

            for (int i = 1; i < lengde; i++)
            {
                Console.SetCursorPosition(30, i + 8);
                Console.Write(vside);

                Console.SetCursorPosition(30 + brede, i + 8);
                Console.Write(hside);

                Console.SetCursorPosition(30 + brede / 2, i + 8);
                Console.Write(loMid);
            }

            Console.SetCursorPosition(30, 8);
            Console.Write(tvkant);

            Console.SetCursorPosition(30 + brede, 8);
            Console.Write(thkant);

            Console.SetCursorPosition(30, 8 + lengde);
            Console.Write(bvkant);

            Console.SetCursorPosition(30 + brede, 8 + lengde);
            Console.Write(bhkant);

            Console.WriteLine("");
            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}
