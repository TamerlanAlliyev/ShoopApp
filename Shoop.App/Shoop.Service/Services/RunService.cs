public class RunService
{
    ProductService productService = new ProductService();
    public void Run()
    {

        Menu();
        string request = Console.ReadLine();
        while (request != "0")
        {
            switch (request)
            {
                case "1":
                    productService.Create();
                    break;
                case "2":
                    productService.GetAll();
                    break;
                case "3":
                    productService.GetById();
                    break;
                default:
                    Console.WriteLine("Wrong choice!");
                    break;
            }
            Menu();
            request = Console.ReadLine();
        }
    }
    void Menu()
    {
        Console.WriteLine("1.Create");
        Console.WriteLine("2.Get Show All");
        Console.WriteLine("3.Get Id");
        Console.WriteLine("0.Close");
    }
}

