using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Enums;

namespace Data.Entities
{
    public class Processor : ComputerComponent
    {
        protected internal Manufacturers Manufacturer;
        protected internal CoreTypes CoreType;

        public Processor(Manufacturers manufacturer, CoreTypes coreType, float price)
        {
            Manufacturer = manufacturer;
            CoreType = coreType;
            Price = price;
        }

        public override string ToString()
        {
            return $"\nProizvodac: {Manufacturer}\nBroj jezgri: {CoreType}\nCijena: {Price} kn\n";
        }
    }
}
