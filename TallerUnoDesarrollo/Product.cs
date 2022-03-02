namespace TallerUnoDesarrollo
{
    public abstract class Product
    {
        public string? Description { get; set; }

        public int Id { get; set; }

        public decimal Price { get; set; }

        public float Tax { get; set; }


        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"\n\n{Id} {Description}\n     Price......: {$"{Price:C2}",12}\n     Tax........:   { $"{Tax:P2}",12 }\n";


        }




    }
}
