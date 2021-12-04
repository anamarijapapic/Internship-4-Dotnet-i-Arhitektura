using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class RAM : ComputerComponent
    {
        protected internal int Size;

        public RAM(int size, float price)
        {
            Size = size;
            Price = price;
        }

        public override string ToString()
        {
            return $"\nVelicina: {Size} GB\nCijena: {Price} kn\n";
        }
    }
}
