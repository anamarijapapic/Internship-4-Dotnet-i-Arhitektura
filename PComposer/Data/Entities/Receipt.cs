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
        public DateTime DateTimeOfReceipt;
        public User User;
        public Order Order;
        public float TotalPrice;
        public float ShippingPrice;
        public int DiscountPercent;

        public Receipt(Order order, User user)
        {
            Random randomNumber = new Random(DateTime.Now.Millisecond);
            ReceiptNumber = randomNumber.Next(10000, 99999);
            DateTimeOfReceipt = DateTime.Now;
            User = user;
            Order = order;
            TotalPrice = order.TotalOrderPrice;
            ShippingPrice = order.ShippingPrice;
            DiscountPercent = order.DiscountPercent;
        }

        public override string ToString()
        {
            return $"\nVas racun:\n\nBroj racuna: {ReceiptNumber}\nVrijeme racuna: {DateTimeOfReceipt}\n\nKupac:\n{User}\n{Order}" +
                $"\n-------------------------------------------------------------------" +
                $"\nUkupna cijena: {TotalPrice} kn + dostava {ShippingPrice} kn" +
                $"\nZbroj: {TotalPrice + ShippingPrice} kn\n" +
                $"\nPopust: {DiscountPercent}% = {(TotalPrice + ShippingPrice) * DiscountPercent / 100} kn" +
                $"\nZbroj s uracunatim popustom: {TotalPrice + ShippingPrice - ((TotalPrice + ShippingPrice) * DiscountPercent / 100)} kn\n";
        }
    }
}
