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
                $"\n\tTotal              {$"{GetValueToPay():C2}",13}";
        }




        //String listado = "";
        //foreach (Product datos in _products)
        //{
        //    listado += datos.ToString;

        //}
        //Console.WriteLine(listado);

        //public product invoice()
        //{
        //    return invoice(_products);
        //}

        //public product invoice(ICollection<Product> _products)
        //{
        //    for (int i = 0; i < _products.Count; i++)
        //    Console.WriteLine(_products[i]);



        //public static Product Invoice(ICollection<Product> Products)

        //{ return Products[1]; }

        //{

        //    String listado = "";
        //    foreach (Product datos in _products){
        //        listado += datos.ToString();

        //    }



    }












}






