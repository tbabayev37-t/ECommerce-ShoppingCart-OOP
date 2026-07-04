public class ShoppingCard
{
    private readonly List<Product> _items;
    public ShoppingCard()
    {
        _items = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _items.Add(product);
        Console.WriteLine($"{product.Name} elave edildi!");
    }
    public void RemoveProduct(int productId)
    {
        var removedProduct = _items.FirstOrDefault(m=>m.Id == productId);
        if(removedProduct != null) {  _items.Remove(removedProduct);
            Console.WriteLine($"{removedProduct.Name} sebetden silindi");
        }
        else { Console.WriteLine("Mehsul tapilmadi!"); }
    }
    public  decimal CalculateTotalCartPrice()
    {
        decimal Total = 0;
        foreach (Product product in _items)
        {
            Total += product.CalculateFinalPrice();
    }
        return Total;
    }
    public  void DisplayCart()
    {
        foreach(var item in _items)
        {
            Console.WriteLine($"mehsul adi: {item.Name}\nilkin qiymet: {item.BasePrice}\nyekun qiymet: {item.CalculateFinalPrice()}");
        }
        Console.WriteLine("------------------------------------------"); 
    }
}
