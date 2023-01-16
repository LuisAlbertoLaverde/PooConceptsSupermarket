using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooConceptsSupermarket
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public string Products { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\t{$"Discount...: {Discount:C2}",15}" +
                $"\n\t{$"Products...: {Products}",15}" +
                $"\n\t{$"Value......: {ValueToPay():C2}",15}";
        }
        public override decimal ValueToPay()
        {
            return (((Price-(decimal)Discount) * (decimal)Tax) + Price);
        }
    }
}
