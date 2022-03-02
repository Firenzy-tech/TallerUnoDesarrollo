namespace TallerUnoDesarrollo
{
    internal class VariablePriceProduct : Product
    {
        public string? Measurement { get; set; }
        public decimal Quantity { get; set; }

        public override decimal GetValueToPay()
        {

            return Quantity * Price;


        }


        public override string ToString()
        {
            return $"{base.ToString()}     Venta por {Measurement}      {Quantity}\n     Value......: {$"{GetValueToPay():C2}",12}";
        }

    }
}
