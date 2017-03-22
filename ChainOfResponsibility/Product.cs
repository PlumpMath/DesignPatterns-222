namespace ChainOfResponsibility
{
    public class Product
    {
        public int Discount { get; set; }
        public double Price { get; set; }
        public bool IsDiscountApproved { get; set; }


        public Product(int Discount, double Price)
        {
            this.Discount = Discount;
            this.Price = Price;
        }


        public double GetDiscountedPrice()
        {
            if (IsDiscountApproved)
            {
                return Price - Price * (Discount / 100);
            }
            else
            {
                return Price;
            }
        }
    }
}