namespace ConceptsPOO.Logic
{
    public class Invoice : IPay
    {
        public string? Description { get; set; }
        public int Id { get; set; }
        public decimal Price { get; set; }
        public float Quantity { get; set; }

        public decimal GetValueToPay()
        {
            return Price * (decimal)Quantity;
        }
        public override string ToString()
        {
            return $"{Id}\t{Description}\n\t" +
                   $"Price..................: {Price,20:C2}\n\t" +
                   $"Quantity...............: {Quantity,20:N2}\n\t" +
                   $"Value to pay...........: {GetValueToPay(),20:C2}";
        }
    }
}
