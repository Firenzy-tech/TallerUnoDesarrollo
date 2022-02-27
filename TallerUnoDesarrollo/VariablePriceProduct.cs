using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerUnoDesarrollo
{
    internal class VariablePriceProduct:Product
    {
        public string Measurement { get; set; }
        public decimal Quantity { get; set; }

        public override decimal GetValueToPay()
        {

            return Quantity * Price;
           // throw new NotImplementedException();

        }


        public override string ToString()
        {
            return $"{base.ToString()} Medida : {Measurement}  Precio Final: {GetValueToPay()}";
        }

    }
}
