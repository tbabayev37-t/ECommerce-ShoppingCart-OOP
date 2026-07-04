public class Clothing:Product
{
    public string Size { get; set; } = null!;
    public double DiscountPercentage { get; set; }
    public Clothing(int id, string name, decimal basePrice,string size, double discountPercentage):base(id,name,basePrice)
    {
       Size = size;
        DiscountPercentage = discountPercentage;
    }
    public override decimal CalculateFinalPrice()
    {
        return BasePrice-(BasePrice* ((decimal)DiscountPercentage/100));
    }
}