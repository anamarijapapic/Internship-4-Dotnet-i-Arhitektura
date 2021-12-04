using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Enums;

namespace Data.Entities
{
    public class Case : ComputerComponent
    {
        protected internal CaseMaterials Material;
        protected internal float Weight;

        public Case(CaseMaterials material, float weight, float price)
        {
            Material = material;
            Weight = weight;
            Price = price;
        }

        public override string ToString()
        {
            return $"\nMaterijal: {Material}\nTezina: {Weight} kg\nCijena: {Price} kn\n";
        }
    }
}
