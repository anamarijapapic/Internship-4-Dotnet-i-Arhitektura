using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Helpers
{
    class ConsolePrintHelpers
    {
        public static void PrintMainMenu()
        {
            Console.Clear();

            Console.WriteLine("+--------------- MENU ---------------+\n"
                            + "| 1 - Sastavi i naruci novo racunalo |\n"
                            + "| 2 - Prikazi moje narudzbe          |\n"
                            + "| 0 - Odjavi se                      |\n"
                            + "+------------------------------------+");
        }

        public static void PrintAssembleComputer()
        {
            Console.WriteLine("+----------------------------------------+\n"
                            + "| Odabir komponenti za slaganje racunala |\n"
                            + "+----------------------------------------+");
        }

        public static void PrintContinue()
        {
            Console.WriteLine("+----------------------------------------+\n"
                            + "| Pritisnite bilo koju tipku za nastavak |\n"
                            + "+----------------------------------------+");
            Console.ReadKey();
        }
    }
}
