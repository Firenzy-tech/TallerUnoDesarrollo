using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerUnoDesarrollo
{
    internal class ComposedProduct : Product
    {
        public decimal Discount { get; set; }

        public ICollection Products { get; set; }



        public override decimal GetValueToPay()
        {
            Decimal ListaPrice=0;
            foreach (Product productDiscount in Products)
            {
                ListaPrice += productDiscount.Price;
             //   Console.WriteLine(productDiscount.Price);
            }
            return ListaPrice;
        }

       

        public override string ToString()
        {
            
            string ListaProducts = "";
            foreach (Product Composed in Products)
            {
                ListaProducts += Composed.Description + "\n";
                //Console.WriteLine(Composed.Description);
            }

            return $"{base.ToString()} \nProductos ancheta\n{ListaProducts}Total a pagar {GetValueToPay()}";
        }
    }
}


//decimal payroll = 0;
//foreach (Employee employee in employees)
//{
//    Console.WriteLine(employee);
//    payroll += employee.GetValueToPay();

//}