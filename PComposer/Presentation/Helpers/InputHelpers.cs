using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Presentation.Helpers
{
    public class InputHelpers
    {
        public static string InputValue(string inputType)
        {
            string input;
            bool isInputValid;

            do
            {
                Console.WriteLine($"{inputType}:");

                input = Console.ReadLine().Trim();
                isInputValid = ValidateInput(input, inputType);

                if (isInputValid) break;

                Console.WriteLine("Neispravan unos!");
            } while (!isInputValid);

            return input;
        }

        static bool ValidateInput(string input, string inputType)
        {
            if (inputType == "Ime" || inputType == "Prezime")
                return input.Length >= 1 && Regex.Match(input, "^[A-Z- ĆČŠĐŠŽ][a-zA-Z- ćčđšž]*$").Success;
            else if (inputType == "Adresa")
                return input.Any(char.IsDigit) && input.Any(char.IsLetter) && input.Split(' ').Length > 1;
            return false;
        }

        public static int InputNumberChoice(int minValue, int maxValue)
        {
            int input;
            bool tryParseSuccess;

            do
            {
                Console.WriteLine("\nUnesite svoj odabir:");

                tryParseSuccess = int.TryParse(Console.ReadLine().Trim(), out input);

                if (tryParseSuccess && input >= minValue && input <= maxValue) break;

                Console.WriteLine("Neispravan unos!");
            } while (!tryParseSuccess || input < minValue || input > maxValue);

            return input;
        }

        public static bool AssembleNewComputer()
        {
            Helpers.ConsolePrintHelpers.PrintAssembleNewChoice();
            return InputNumberChoice(0, 1) == 1;
        }

        public static string InputPromoCode(Dictionary<string, int> promoCodes)
        {
            string input;
            bool isInputValid;

            do
            {
                Console.WriteLine("\nUnesite promo kod:");

                input = Console.ReadLine().Trim().ToUpper();
                isInputValid = ValidatePromoCode(promoCodes, input);

                if (isInputValid) break;

                Console.WriteLine("Kod za popust nije valjan!");
            } while (!isInputValid);

            return input;
        }

        public static bool ValidatePromoCode(Dictionary<string, int> promoCodes, string promoCode)
        {
            return promoCodes.Keys.Contains(promoCode);
        }
    }
}
