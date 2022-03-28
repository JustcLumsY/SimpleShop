using System.Collections.Generic;
using System;
using System.Linq;

namespace SimpleShop
{
    public class Shop
    {
        public List<ShopItem> ShopItems { get; set; }
        public List<ShopItem> cart = new List<ShopItem>();
        public int totalPrice { get; set; } = 0;
        public Shop()
        {
            ShopItems = new List<ShopItem>();

            ShopItems.Add(new ShopItem("Cup", 35, "0"));
            ShopItems.Add(new ShopItem("Table", 150, "1"));
            ShopItems.Add(new ShopItem("Sofa", 750, "2"));
            ShopItems.Add(new ShopItem("Chair", 1000, "3"));
            ShopItems.Add(new ShopItem("Painting", 2500, "4"));
            ShopItems.Add(new ShopItem("Mouse", 240, "5"));
            ShopItems.Add(new ShopItem("Cable", 122, "6"));
            ShopItems.Add(new ShopItem("Telephone", 2220, "7"));
        }
        public void RunShop(Shop shop, Customer customer)
        {
            while (true)
            {
                Console.Clear();
                shop.PrintShopList();
                Console.WriteLine();
                Console.WriteLine("What do you want to buy?");
                Console.WriteLine();
                shop.ShowShoppingCart();
                var userInput = Console.ReadLine();
                shop.AddToCart(userInput);
                if (userInput == "P".ToLower())
                {
                    shop.BuyCart(customer);
                    Console.ReadLine();
                    return;
                }
            }
        }
        public void BuyCart(Customer customer)
        {           
            customer.BankInformation.Balance -= totalPrice;
            Console.WriteLine($"You bought all items in the cart for: {totalPrice} NOK");
        }

        public void AddToCart(string userInput)
        {
            var item = ShopItems.FirstOrDefault(x => x.Id == userInput);
            cart.Add(item);
        }

        public void ShowShoppingCart(string userInput)
        {
            var item = ShopItems.FirstOrDefault(x => x.Id == userInput);
            Console.WriteLine(item.ItemName + item.Price);
        }
        public void ShowShoppingCart()
        {
            if (cart.Count == 0) {}
            else
            {
                    Console.WriteLine("Shopping cart:");
                foreach (var item in cart)
                {
                    Console.WriteLine($"{item.ItemName} {item.Price} NOK");
                    totalPrice += item.Price;
                }
                Console.WriteLine();
                Console.WriteLine($"Total Price: {totalPrice} NOK");
                Console.WriteLine("P to purchase cart");
            } 
        }

        public void PrintShopList() 
        {
            foreach (var item in ShopItems)
            {
                Console.WriteLine($"{item.Id} {item.ItemName} {item.Price} NOK");
            }
        }
    }
}

