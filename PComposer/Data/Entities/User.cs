using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public int Distance { get; set; }

        public User(string name, string surname, string address)
        {
            Name = name;
            Surname = surname;
            Address = address;
            Distance = GenerateDistance();
        }

        public static int GenerateDistance()
        {
            Random randomDistance = new Random();
            return (randomDistance.Next(50, 1000));
        }

        public override string ToString()
        {
            return $"\nIme: {Name}\nPrezime: {Surname}\nAdresa: {Address}\nUdaljenost adrese od prodajnog centra: {Distance} km\n";
        }
    }
}
