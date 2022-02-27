using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerUnoDesarrollo
{
    public abstract class Product
    {
        public string Description { get; set; }

        public int Id { get; set; }

        public decimal Price { get; set; }

        public float Tax { get; set; }


        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"Id: {Id} Descripción: {Description} Price: {Price} Tax: {Tax:P2}  Precio Con impuesto: ";   
               
        }

    
    }
}
