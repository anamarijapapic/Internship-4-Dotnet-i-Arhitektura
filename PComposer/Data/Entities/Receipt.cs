using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Receipt
    {
        public int ReceiptNumber;
        public User User;
        public Order Order;
        public float TotalPrice;

        public Receipt(Order order, User user)
        {
            Random randomNumber = new Random(DateTime.Now.Millisecond);
            ReceiptNumber = randomNumber.Next(10000, 99999);
            User = user;
            Order = order;
            TotalPrice = order.TotalOrderPrice;
        }

        public override string ToString()
        {
            return $"\nVas racun:\n\nBroj racuna: {ReceiptNumber}\n\nKupac:\n{User}\n{Order}" +
                $"\n-------------------------------------------------------------------" +
                $"\nUkupna cijena: {TotalPrice} kn\n";
        }
    }
}
