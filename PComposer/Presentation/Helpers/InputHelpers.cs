using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
                return input.Any(char.IsDigit) && input.Split(' ').Length > 1;
            return false;
        }
    }
}
