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

            Console.WriteLine($"Dobrodosli, {Domain.Domain.CurrentUser.Name} {Domain.Domain.CurrentUser.Surname}!");

            Console.WriteLine(Domain.Domain.CurrentUser);

            Helpers.ConsolePrintHelpers.PrintContinue();
        }

        static void MainMenu()
        {
            Helpers.ConsolePrintHelpers.PrintMainMenu();

            var userChoice = (MainMenuOptions)Helpers.InputHelpers.InputNumberChoice(0, 2);

            Console.Clear();

            switch (userChoice)
            {
                case MainMenuOptions.AssembleAndOrder:
                    do
                    {
                        AssembleComputer();
                    } while (Helpers.InputHelpers.AssembleNewComputer());
                    ChooseShipmentMethod();
                    // ChooseDiscount();
                    ConfirmOrderOrAssembleNew();
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
            Domain.Domain.Computer = new();

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

            Domain.Domain.Computer.CalculateWeight();

            Domain.AccessData.SetData.AddComputerToOrder(Domain.Domain.Computer);

            Console.WriteLine("\nHvala! Sve komponente za sastavljanje ovog racunala su zabiljezene.");

            Helpers.ConsolePrintHelpers.PrintContinue();
        }

        static void ChooseShipmentMethod()
        {   
            Helpers.ConsolePrintHelpers.PrintShipmentMethod();

            var userChoice = (SubmenuShipmentOptions)Helpers.InputHelpers.InputNumberChoice(0, 1);

            switch (userChoice)
            {
                case SubmenuShipmentOptions.None:
                    Domain.AccessData.SetData.FixWeight(Domain.Domain.Computer);
                    break;
                case SubmenuShipmentOptions.Shipping:
                    Domain.Domain.Order.CalculateShippingPrice(Domain.Domain.CurrentUser.Distance);
                    break;
            }

            Console.WriteLine($"{Domain.Domain.Order}");

            Helpers.ConsolePrintHelpers.PrintContinue();
        }

        static void ConfirmOrderOrAssembleNew()
        {
            Helpers.ConsolePrintHelpers.PrintConfirmOrder();

            var userChoice = (SubmenuConfirmOrderOptions)Helpers.InputHelpers.InputNumberChoice(0, 2);

            switch (userChoice)
            {
                case SubmenuConfirmOrderOptions.ConfirmOrder:
                    Domain.AccessData.SetData.AddReceipt(Domain.Domain.Order, Domain.Domain.CurrentUser);
                    Helpers.ConsolePrintHelpers.ThankYou();
                    Console.WriteLine(Domain.Domain.Receipt);
                    Helpers.ConsolePrintHelpers.PrintReturnToMainMenu();
                    MainMenu();
                    break;
                case SubmenuConfirmOrderOptions.AssembleNew:
                    AssembleComputer();
                    ChooseShipmentMethod();
                    ConfirmOrderOrAssembleNew();
                    break;
                case SubmenuConfirmOrderOptions.CancelOrder:
                    MainMenu();
                    break;
            }
        }
    }
}
