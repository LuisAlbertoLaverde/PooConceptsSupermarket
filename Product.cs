namespace PooConceptsSupermarket
{
    public abstract class Product
    {
        public string Description { get; set; }
        public int Id { get; set; }
        public decimal Price { get; set; }
        public float Tax { get; set; }
        public override string ToString()
        {
            return $"{Id}, {Description}, " +
                $"\n\t{$"Price......: {Price:C2}",15}" +
                $"\n\t{$"Tax........: {Tax:P2}",19}";
        }
        public abstract decimal ValueToPay();
    }

}
