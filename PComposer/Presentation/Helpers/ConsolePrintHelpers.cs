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

        public static void PrintAssembleNewChoice()
        {
            Console.WriteLine("\n+--- Odaberite opciju za nastavak ---+\n"
                              + "| 0 - Nastavi s kupnjom              |\n"
                              + "| 1 - Sastavi novi PC                |\n"
                              + "+------------------------------------+");
        }

        public static void PrintShipmentMethod()
        {
            Console.Clear();

            Console.WriteLine("+---- Odabir nacina preuzimanja paketa ----+\n"
                            + "| 0 - Osobno preuzimanje (besplatno)       |\n"
                            + "| 1 - Dostava na adresu                    |\n"
                            + "+------------------------------------------+");
        }

        public static void PrintConfirmOrder()
        {
            Console.Clear();

            Console.WriteLine("+---- Odaberite opciju za nastavak ----+\n"
                            + "| 0 - Dovrsi narudzbu i kupi           |\n"
                            + "| 1 - Sastavi novi PC                  |\n"
                            + "| 2 - Odustani od narudzbe             |\n"
                            + "+--------------------------------------+");
        }

        public static void ThankYou()
        {
            Console.Clear();

            Console.WriteLine("+------------------------------+\n"
                            + "|   Narudzba je zaprimljena!   |\n"
                            + "|   Hvala Vam na povjerenju!   |\n"
                            + "+------------------------------+");
        }

        public static void PrintReturnToMainMenu()
        {
            Console.WriteLine("+--------------------------------------------------------+\n"
                            + "| Pritisnite bilo koju tipku za povratak na pocetni menu |\n"
                            + "+--------------------------------------------------------+");
            Console.ReadKey();
        }

        public static void PrintOrderHistory()
        {
            Console.WriteLine("+-------------------------------+\n"
                            + "| Prikaz mojih proslih narudzbi |\n"
                            + "+-------------------------------+");
        }

        public static void PrintDiscountSubmenu()
        {
            Console.Clear();

            Console.WriteLine("+---- Odaberite moguci popust ----+\n"
                            + "| 0 - Popust za vjerno clanstvo   |\n"
                            + "| 1 - Popust na kolicinu          |\n"
                            + "| 2 - Popust unosom koda          |\n"
                            + "+---------------------------------+");
        }
    }
}
