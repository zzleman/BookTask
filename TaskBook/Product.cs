namespace TaskBook
{
	public class Product
	{
		private string productName;
		private int costPrice;
		private int saledPrice;

        public Product(string productName, int costPrice, int saledPrice)
        {
            this.productName = productName;
            this.costPrice = costPrice;
            this.saledPrice = saledPrice;
        }

        public string ProductName { get => productName; set => productName = value; }
        public int CostPrice { get => costPrice; set => costPrice = value; }
        public int SaledPrice { get => saledPrice; set => saledPrice = value; }
    }
}

