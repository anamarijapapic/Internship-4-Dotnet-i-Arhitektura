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

            var userMenuChoice = (Enums.MainMenuOptions)Helpers.InputHelpers.InputNumberChoice(0, 2);

            Console.Clear();

            switch (userMenuChoice)
            {
                case Enums.MainMenuOptions.AssembleAndOrder:
                    // AssembleAndOrder();
                    break;
                case Enums.MainMenuOptions.ShowOrderHistory:
                    // ShowOrderHistory();
                    break;
                case Enums.MainMenuOptions.Logout:
                    Console.WriteLine($"Pozdrav, {Domain.Domain.CurrentUser.Name} {Domain.Domain.CurrentUser.Surname}!\nUspjesno ste odjavljeni!");
                    break;
            }
        }
    }
}
