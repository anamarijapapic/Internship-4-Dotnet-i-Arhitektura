using Data.Enums;

namespace Data.Entities
{
    public class HardDisk : ComputerComponent
    {
        protected internal DriveTypes DriveType;
        protected internal int Size;
        protected internal float Weight;

        public HardDisk(DriveTypes driveType, int size, float weight, float price)
        {
            DriveType = driveType;
            Size = size;
            Weight = weight;
            Price = price;
        }

        public override string ToString()
        {
            return $"\nTip: {DriveType}\nVelicina: {Size} TB\nTezina: {Weight} kg\nCijena: {Price} kn\n";
        }
    }
}
