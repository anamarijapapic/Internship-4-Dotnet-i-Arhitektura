using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Order
    {
        public int OrderNumber;
        public List<Computer> Computers = new();
        public float TotalWeight;
        public float TotalComponentsPrice = 0;
        public float TotalAssemblyPrice = 0;
        public float TotalOrderPrice = 0;
        public float ShippingPrice = 0;
        public string Vehicle = "osobno preuzimanje";

        public Order()
        {
            Random randomNumber = new Random(DateTime.Now.Millisecond);
            OrderNumber = randomNumber.Next(10000, 99999);
        }

        public void CalculateShippingPrice(int distance)
        {
            if (TotalWeight < 3)
            { // motorcycle 
                ShippingPrice = (float)Math.Round(((float)distance / 10 * 5) * 100f) / 100f;
                Vehicle = "motor";
            }
            else if (TotalWeight >= 3 && TotalWeight < 10)
            {
                // car
                ShippingPrice = (float)Math.Round(((float)distance / 5 * 3) * 100f) / 100f;
                Vehicle = "automobil";
            }
            else
            {
                // truck
                ShippingPrice = (float)Math.Round(((float)distance / 20 * 10) * 100f) / 100f;
                Vehicle = "kamion";
            }
        }

        public override string ToString()
        {
            return $"\nBroj narudzbe: {OrderNumber}\nUkupna tezina narudzbe: {TotalWeight} kg\n" +
                $"Ukupna cijena svih racunala: {TotalOrderPrice} kn\nUkupna cijena svih komponenti za sva racunala: {TotalComponentsPrice} kn\n" +
                $"Ukupna cijena sastavljanja svih komponenti za sva racunala: {TotalAssemblyPrice} kn\nCijena dostave: {ShippingPrice} kn ({Vehicle})\n";
        }
    }
}
