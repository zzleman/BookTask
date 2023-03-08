namespace TaskBook
{
	public class Book : Product
	{
		private string authorName;
		private int pageCount;
		private int discountPercent;

        public Book(string authorName, int pageCount, int discountPercent, string productName, int costPrice, int saledPrice) :base( productName, costPrice, saledPrice)
        {
            this.authorName = authorName;
            this.pageCount = pageCount;
            this.discountPercent = discountPercent;
        }

        public string GetInfo()
        {
            return $"Author:{authorName}, Book Name:{ProductName}, {pageCount} page, Cost Price:{CostPrice}azn, Sale Price:{SaledPrice}azn, Discount:{discountPercent}%, ";
        }

        public int GetDiscountedPrice()
        {
            SaledPrice = SaledPrice- ((discountPercent *SaledPrice)/100);

            return SaledPrice;
        }
    }
}

