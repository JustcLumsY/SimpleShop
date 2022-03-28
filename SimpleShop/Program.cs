using System;

namespace SimpleShop
{
    public class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();
            Customer customer =
            new Customer("John",
                new Address("Roadname", "15"),
                    new BankInformation("DNB", "1111 2222 3333 4444", 20000, "NOK")
            );
            shop.RunShop(shop, customer);
        }  
    }
}
