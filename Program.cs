ShoppingCard shopping = new ShoppingCard();
try
{
    Electronics electronics = new Electronics(1, "Mouse", 250, 3);
    Clothing clothing = new Clothing(2, "T-shirt", 100, "M", 20);
    shopping.AddProduct(clothing);
    shopping.AddProduct(electronics);
}
catch(Exception ex)
{
    Console.WriteLine($"[Gozlenilmez xeta:] {ex.Message}");
}
shopping.DisplayCart();
decimal totalPrice = shopping.CalculateTotalCartPrice();
Console.WriteLine($"Sebetin umumi odenis meblegi: {totalPrice} AZN");

Console.WriteLine("Xetali mehsul cagirisi");
try
{
    Electronics electronics = new Electronics(4, "Keyboard", -120, 6);
    shopping.AddProduct(electronics);
}
catch(ArgumentException ex)
{
    Console.WriteLine($"Xeta bas verdi: {ex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine($"Xeta bas verdi: {ex.Message}");
}
Console.ReadLine();