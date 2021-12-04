using System;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            UserLogin();
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
    }
}
