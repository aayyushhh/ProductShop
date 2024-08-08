using ProductShop.Models;

public class Program
{
    static void Main(string[] args)
    {
        StartApp();
    }

    public static void StartApp()
    {
        while (true)
        {
            Console.WriteLine("1.Create Order");
            Console.WriteLine("2.Display Order");
            Console.WriteLine("3.Exit");

            int userinput = int.Parse(Console.ReadLine());
            switch (userinput)
            {
                case 1:
                    AddOrder();
                    break;
                case 2:
                    PrintOrder();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;

            }
        }
    }

    public static void AddOrder()
    {
        
        string choice = "Y";

        Customer customer1 = new Customer(1, "Ayush");
        Order order1 = new Order(1, DateTime.Now);

        while (choice == "Y")
        { 
            Console.WriteLine("Enter product id");
            int pro_id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product name");
            string product_name = Console.ReadLine();
            Console.WriteLine("Enter price: ");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter discount Percentage :");
            double disccount_percent = double.Parse(Console.ReadLine());
            Product newpro = new Product(pro_id, product_name, price, disccount_percent);
            Console.WriteLine("Enter quantity");
            int new_quant = int.Parse(Console.ReadLine());
            LineItem lineItem = new LineItem(pro_id, new_quant, newpro);
            order1.AddLineItem(lineItem);
            Console.WriteLine("Items Added !");

            Console.WriteLine("Do you want to add item? (Y/N)");
            choice = Console.ReadLine();
        }
        Customer.OrdersList.Add(order1);

    }

    public static void PrintOrder()
    {
        if (Customer.OrdersList == null)
        {
            Console.WriteLine("No orders");
            return;

        }

        foreach (Order order in Customer.OrdersList)
        {
            Console.WriteLine("Order Details");
            Console.WriteLine($"Order ID : {order.OrderId}");
            Console.WriteLine($"Order Name : {order.OrderDate}");
            Console.WriteLine(new string('-', 140));
            if (order.LineItems == null)
            {
                Console.WriteLine("No LineItems");
                continue;
            }
            Console.WriteLine($"| {"LineItem ID",-12} | {"Product ID",-12} | {"Product Name",-12} | {"Product Price",-12} | {"Discount Price",-12} ");
            Console.WriteLine(new string('-', 140));
            foreach (LineItem line in order.LineItems)
            {
                Console.WriteLine($"| {line.ID,-12} | {line.Product.ProductId,-12} | {line.Product.ProductName,-12} | {line.Product.ProductPrice,-12} | {line.Product.ProductPriceAfterDiscount,-12} ");
            }
            Console.WriteLine("Total cost " + order.CalculateOrderPrice());
            Console.WriteLine(new string('-', 140));

        }



    }
}
