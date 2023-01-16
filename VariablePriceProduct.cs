using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooConceptsSupermarket
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public float Quantity { get; set; }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\t{$"Measurement: {Measurement}",15}"+
                $"\n\t{$"Quantity...: {Quantity}",15}"+
                $"\n\t{$"Value......: {ValueToPay():C2}",15}";
        }
        public override decimal ValueToPay()
        {
            return ((Price * (decimal)Tax) + Price)*(decimal)Quantity;
        }
    }
}
