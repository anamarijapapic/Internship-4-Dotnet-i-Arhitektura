using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Computer
    {
        public Processor Processor;
        public RAM RAM;
        public int quantityOfRAM;
        public HardDisk HardDisk;
        public Case Case;
        public float Weight;
        public float ComponentsPrice;
        public float AssemblyPrice;
        public float TotalPrice;

        public void CalculateWeight()
        {
            Weight = HardDisk.Weight + Case.Weight;
        }

        public void CalculateComponentsPrice()
        {
            ComponentsPrice = (float)Math.Round((Processor.Price + RAM.Price * quantityOfRAM + HardDisk.Price + Case.Price) * 100f) / 100f;
        }

        public void CalculateAssemblyPrice()
        {
            AssemblyPrice = (float)Math.Round(((3 + quantityOfRAM) * 25) * 100f) / 100f;
        }

        public void CalculateTotalPrice()
        {
            TotalPrice = (float)Math.Round((ComponentsPrice + AssemblyPrice) * 100f) / 100f;
        }

        public void CalculatePrices()
        {
            CalculateComponentsPrice();
            CalculateAssemblyPrice();
            CalculateTotalPrice();
        }

        public override string ToString()
        {
            return $"\nProcesor: {Processor}\nRAM: {RAM}\t\tx{quantityOfRAM}\nHard disk: {HardDisk}\nKuciste: {Case}\n" +
                $"Cijena svih komponenti: {ComponentsPrice} kn\nCijena usluge sastavljanja: {AssemblyPrice} kn\nUkupna cijena: {TotalPrice} kn";
        }
    }
}
