using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerUnoDesarrollo
{
    public class Invoice: IPay
    {
    private ICollection<Product> _products = new List<Product>();

        public Invoice()  { }

        decimal VentaFactura=0;


        public void AddProduct(Product product)
        {
            _products.Add(product);
         
        }




        public decimal GetValueToPay()
        {

            foreach (Product Vent in _products)
            {
                VentaFactura += Vent.GetValueToPay();
            }  


            return VentaFactura;
        }


        public override string ToString()
        {
            Console.WriteLine("\nReceipt\n.........................................");
            foreach (Product Descrip in _products)
            {
                Console.WriteLine(Descrip.ToString());
            }


            return $"                    ===================" +
                $"\n\tTotal              {$"{GetValueToPay():C2}",12}";
        }







    }












}






