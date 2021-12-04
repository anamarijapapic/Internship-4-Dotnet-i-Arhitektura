using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Helpers
{
    class ChooseComponentHelpers
    {
        public static void ChooseProcessor()
        {
            var processors = Domain.AccessData.GetData.GetProcessors();
            
            foreach (var processor in processors)
            {
                Console.WriteLine($"{processor.Key} - {processor.Value}");
            }
                
            var userChoice = Helpers.InputHelpers.InputNumberChoice(0, processors.Count - 1);

            Console.WriteLine($"\nOdabrali ste procesor: {processors[userChoice]}");

            Domain.AccessData.SetData.AddProcessor(processors[userChoice]);
        }

        public static void ChooseRAM()
        {
            var RAMs = Domain.AccessData.GetData.GetRAMs();

            foreach (var RAM in RAMs)
            {
                Console.WriteLine($"{RAM.Key} - {RAM.Value}");
            }

            var userChoice = Helpers.InputHelpers.InputNumberChoice(0, RAMs.Count - 1);

            Console.WriteLine("\nZeljena kolicina RAM kartica (najmanje 1, najvise 4)?");
            
            var quantity = Helpers.InputHelpers.InputNumberChoice(1, 4);
            
            Console.WriteLine($"\nOdabrali ste RAM: {RAMs[userChoice]}\t\tx{quantity}\n");
            
            Domain.AccessData.SetData.AddRAM(RAMs[userChoice], quantity);
        }

        public static void ChooseHardDisk()
        {
            var hardDisks = Domain.AccessData.GetData.GetHardDisks();
            
            foreach (var hardDisk in hardDisks)
            {
                Console.WriteLine($"{hardDisk.Key} - {hardDisk.Value}");
            }
                
            var userChoice = Helpers.InputHelpers.InputNumberChoice(0, hardDisks.Count - 1);

            Console.WriteLine($"\nOdabrali ste hard disk: {hardDisks[userChoice]}");

            Domain.AccessData.SetData.AddHardDisk(hardDisks[userChoice]);
        }

        public static void ChooseCase()
        {
            var cases = Domain.AccessData.GetData.GetCases();

            foreach (var computerCase in cases)
            {
                Console.WriteLine($"{computerCase.Key} - {computerCase.Value}");
            }
                
            var userChoice = Helpers.InputHelpers.InputNumberChoice(0, cases.Count - 1);

            Console.WriteLine($"\nOdabrali ste kuciste: {cases[userChoice]}");
            
            Domain.AccessData.SetData.AddCase(cases[userChoice]);
        }
    }
}
