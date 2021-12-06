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
