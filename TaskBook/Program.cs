using TaskBook;
Book book = new Book("Stefan Zweig",96,30,"The Royal Game",6,10);

Console.WriteLine(book.GetInfo()+ "Discounted Price:" + book.GetDiscountedPrice() + "azn");
