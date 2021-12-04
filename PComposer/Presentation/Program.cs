using Presentation.Enums;
using System;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            UserLogin();

            MainMenu();
        }

        static void UserLogin()
        {
            Console.WriteLine("+--------------------------+\n| Logirajte se u PComposer |\n+--------------------------+");
            Console.WriteLine("\nUnesite svoje podatke:");
            var name = Helpers.InputHelpers.InputValue("Ime");
            var surname = Helpers.InputHelpers.InputValue("Prezime");
            var address = Helpers.InputHelpers.InputValue("Adresa");
            Domain.AccessData.SetData.LoginUser(name, surname, address);
            Console.Clear();
            Console.WriteLine($"Dobrodosli, {Domain.Domain.CurrentUser.Name} {Domain.Domain.CurrentUser.Surname}!\n");
        }

        static void MainMenu()
        {
            Helpers.ConsolePrintHelpers.PrintMainMenu();

            var userChoice = (MainMenuOptions)Helpers.InputHelpers.InputNumberChoice(0, 2);

            Console.Clear();

            switch (userChoice)
            {
                case MainMenuOptions.AssembleAndOrder:
                    AssembleComputer();
                    // ChooseShipmentMethod();
                    // ContinueToCartOrAssembleNew();
                    // ChooseDiscount();
                    // ConfirmOrderOrAssembleNew();
                    break;
                case MainMenuOptions.ShowOrderHistory:
                    // ShowOrderHistory();
                    break;
                case MainMenuOptions.Logout:
                    Console.WriteLine($"Pozdrav, {Domain.Domain.CurrentUser.Name} {Domain.Domain.CurrentUser.Surname}!\nUspjesno ste odjavljeni!");
                    break;
            }
        }

        static void AssembleComputer()
        {
            Helpers.ConsolePrintHelpers.PrintAssembleComputer();

            foreach (var option in (SubmenuAssembleOptions[])Enum.GetValues(typeof(SubmenuAssembleOptions)))
            {
                Console.WriteLine($"\nPonuda {option}:\n");
                switch (option)
                {
                    case SubmenuAssembleOptions.Processor:
                        Helpers.ChooseComponentHelpers.ChooseProcessor();
                        break;
                    case SubmenuAssembleOptions.RAM:
                        Helpers.ChooseComponentHelpers.ChooseRAM();
                        break;
                    case SubmenuAssembleOptions.HardDisk:
                        Helpers.ChooseComponentHelpers.ChooseHardDisk();
                        break;
                    case SubmenuAssembleOptions.Case:
                        Helpers.ChooseComponentHelpers.ChooseCase();
                        break;
                }
            }

            Domain.Domain.Computer.CalculatePrices();

            Console.WriteLine($"{Domain.Domain.Computer}");
            Console.WriteLine("\nHvala! Sve komponente za sastavljanje ovog racunala su zabiljezene.");
            Helpers.ConsolePrintHelpers.PrintContinue();
        }
    }
}
