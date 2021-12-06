using Data.Entities;
using Data.Enums;
using System;
using System.Collections.Generic;

namespace Data
{
    public class Seed
    {
        public static readonly List<ComputerComponent> AllComponents = new()
        {
            new Processor(manufacturer: Manufacturers.AMD,
                      coreType: CoreTypes.DecaCore,
                      price: 4499.00F),
            new Processor(manufacturer: Manufacturers.Intel,
                      coreType: CoreTypes.OctaCore,
                      price: 3846.55F),
            new Processor(manufacturer: Manufacturers.AMD,
                      coreType: CoreTypes.OctaCore,
                      price: 4099.00F),
            new Processor(manufacturer: Manufacturers.Intel,
                      coreType: CoreTypes.QuadCore,
                      price: 749.00F),

            new RAM(size: 4,
                price: 149.00F),
            new RAM(size: 8,
                price: 499.00F),

            new HardDisk(driveType: DriveTypes.HDD,
                size: 2,
                weight: 2,
                price: 689.00F),
            new HardDisk(driveType: DriveTypes.HDD,
                size: 1,
                weight: 1,
                price: 531.05F),
            new HardDisk(driveType: DriveTypes.SDD,
                size: 2,
                weight: 0,
                price: 2299.49F),
            new HardDisk(driveType: DriveTypes.SDD,
                size: 1,
                weight: 0,
                price: 919.00F),

            new Case(material: CaseMaterials.Metal,
                weight: 1.5F,
                price: 475.69F),
            new Case(material: CaseMaterials.Plastic,
                weight: 1F,
                price: 159.00F),
            new Case(material: CaseMaterials.Carbon,
                weight: 0.5F,
                price: 781.22F)
        };

        private static readonly Random randomNumber = new();

        public static Dictionary<string, int> PromoCodes = new()
        {
            { "INTERNSHIP", randomNumber.Next(1, 100) },
            { "DUMP202122", randomNumber.Next(1, 100) },
            { "PCOMPOSER1", randomNumber.Next(1, 100) },
            { "POPUST2021", randomNumber.Next(1, 100) }
        };
    }
}
