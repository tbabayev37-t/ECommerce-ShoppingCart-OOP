public class Product
{
    private int _id;
    private string _name = null!;
    private decimal _basePrice;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public string Name
    {
        get { return _name; }
        set { if (string.IsNullOrEmpty(value)) { throw new ArgumentException("Ad daxil etmediniz");            
            }
            _name = value;
        }
    }
    public decimal BasePrice {
        get { return _basePrice; }
        set { if (value <= 0) { throw new Exception("Deyer menfi ve 0 ola bilmez"); }
            _basePrice = value;
        }
       
     }
    public Product(int id,string name, decimal basePrice)
    {
        Id= id;
        Name = name;
        BasePrice = basePrice;
    }
    public virtual decimal CalculateFinalPrice()
    {
        return _basePrice;
    }
}
