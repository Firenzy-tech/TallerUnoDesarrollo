using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerUnoDesarrollo
{
    internal class ProductPriceFixed : Product
    {
        public override decimal GetValueToPay()
        {
            return (Price * (decimal)Tax) + Price;
            //throw new NotImplementedException();


        }


        public override string ToString()
        {
            return $"{base.ToString()}     Value......: {$"{GetValueToPay():C2}",12}";
        }
    }
}
