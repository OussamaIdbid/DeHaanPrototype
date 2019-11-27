namespace CashModel
{
    public class ReceiptLine
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice
        {
            get
            {
                return Quantity * Price;
            }
        }
    }
}
