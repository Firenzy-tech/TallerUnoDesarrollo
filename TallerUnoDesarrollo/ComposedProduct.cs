using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerUnoDesarrollo
{
    internal class ComposedProduct: Product
    {
        public decimal Discount { get; set; }

        public string Products { get; set; } 

        public override decimal GetValueToPay()
        {
            throw new NotImplementedException();
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
