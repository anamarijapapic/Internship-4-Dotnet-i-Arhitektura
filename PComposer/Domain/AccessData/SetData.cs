using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AccessData
{
    public class SetData
    {
        public static void LoginUser(string name, string surname, string address)
        {
            Domain.CurrentUser = new(name, surname, address);
        }

        public static void AddProcessor(Processor processor)
        {
            Domain.Computer.Processor = processor;
        }

        public static void AddRAM(RAM RAM, int quantity)
        {
            Domain.Computer.RAM = RAM;
            Domain.Computer.quantityOfRAM = quantity;
        }

        public static void AddHardDisk(HardDisk hardDisk)
        {
            Domain.Computer.HardDisk = hardDisk;
        }

        public static void AddCase(Case computerCase)
        {
            Domain.Computer.Case = computerCase;
        }

        public static void AddComputerToOrder(Computer computer)
        {
            Domain.Order.Computers.Add(computer);
            Domain.Order.TotalWeight += computer.Weight;
            Domain.Order.TotalOrderPrice += computer.TotalPrice;
            Domain.Order.TotalComponentsPrice += computer.ComponentsPrice;
            Domain.Order.TotalAssemblyPrice += computer.AssemblyPrice;
        }

        public static void FixWeight(Computer computer)
        {
            Domain.Order.TotalWeight -= computer.Weight;
        }

        public static void AddReceipt(Order order, User user)
        {
            Domain.Receipt = new(order, user);
        }
    }
}
