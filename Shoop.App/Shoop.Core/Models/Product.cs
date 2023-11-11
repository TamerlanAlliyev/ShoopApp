public class Product
{
    static int _id;
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int StockCount { get; set; }
    public ProductCategory Category { get; set; }
    public Product()
    {
        _id++;
        Id = _id;
    }
}

