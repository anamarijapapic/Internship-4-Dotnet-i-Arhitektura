using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AccessData
{
    public class GetData
    {
        public static Dictionary<int, Processor> GetProcessors()
        {
            var processors = new Dictionary<int, Processor>();
            int i = 0;

            foreach (var component in Data.Seed.AllComponents)
            {
                if (component is Processor)
                {
                    processors.Add(i++, component as Processor);
                }
            }

            return processors;
        }

        public static Dictionary<int, RAM> GetRAMs()
        {
            var RAMs = new Dictionary<int, RAM>();
            int i = 0;

            foreach (var component in Data.Seed.AllComponents)
            {
                if (component is RAM)
                {
                    RAMs.Add(i++, component as RAM);
                }
            }

            return RAMs;
        }

        public static Dictionary<int, HardDisk> GetHardDisks()
        {
            var hardDisks = new Dictionary<int, HardDisk>();
            int i = 0;

            foreach (var component in Data.Seed.AllComponents)
            {
                if (component is HardDisk)
                {
                    hardDisks.Add(i++, component as HardDisk);
                }
            }

            return hardDisks;
        }

        public static Dictionary<int, Case> GetCases()
        {
            var cases = new Dictionary<int, Case>();
            int i = 0;

            foreach (var component in Data.Seed.AllComponents)
            {
                if (component is Case)
                {
                    cases.Add(i++, component as Case);
                }
            }

            return cases;
        }

        public static Dictionary<string, int> GetPromoCodes()
        {
            var promoCodes = new Dictionary<string, int>();

            foreach (var promoCode in Data.Seed.PromoCodes)
            {
                promoCodes.Add(promoCode.Key, promoCode.Value);
            }

            return promoCodes;
        }
    }
}
