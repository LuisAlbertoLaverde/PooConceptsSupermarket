namespace PooConceptsSupermarket
{
    public class FixedPriceProduct : Product
    {        
        public override string ToString()
        {            
            return $"{base.ToString()}" +
                $"\n\t{$"Value......: {ValueToPay():C2}",15}";
        }
        public override decimal ValueToPay()
        {
            return (Price * (decimal)Tax) + Price;
        }
    }
}
