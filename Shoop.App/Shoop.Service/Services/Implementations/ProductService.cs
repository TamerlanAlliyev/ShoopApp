
public class ProductService : IProductService
{
        List<Product> Products = new List<Product>();
        public void Create()
        {
            Console.WriteLine("Add Name");
            string name = Console.ReadLine();
            Console.WriteLine("Add Price");
            double.TryParse(Console.ReadLine(), out double price);
            Console.WriteLine("Add Stock Count");
            int.TryParse(Console.ReadLine(), out int stockcount);
            Console.WriteLine("Add Category");
            Console.WriteLine($"1.{ProductCategory.Eat}");
            Console.WriteLine($"1.{ProductCategory.Clean}");
            int.TryParse(Console.ReadLine(), out int category);
            Product product = new Product();
            product.Name = name;
            product.Price = price;
            product.StockCount = stockcount;
            product.Category =(ProductCategory)category;
            Products.Add(product);
        }

        public void GetAll()
        {
            foreach (Product item in Products)
        {
            Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, Stock Count: {item.StockCount}, Category: {item.Category}");
        }
        }

        public void GetById()
        {
            Console.WriteLine("Add Id");
            int.TryParse(Console.ReadLine(), out int id);
            foreach (Product item in Products)
            {
                if (item.Id == id)
                {
                Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, Stock Count: {item.StockCount}, Category: {item.Category}");
                    return;
                }
            }
            Console.WriteLine("Product not found");

        }
    }
