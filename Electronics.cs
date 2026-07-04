public class Electronics:Product
{
    public int WarrantyMonths { get; set; }
    public Electronics(int id, string name, decimal basePrice,int warrantyMonths):base(id,name,basePrice)
    {
        WarrantyMonths = warrantyMonths;
    }
    public override decimal CalculateFinalPrice()
    {
        return BasePrice*1.10m;//sonuna m herfi qoyub decimal edirik!!!
    }
}
