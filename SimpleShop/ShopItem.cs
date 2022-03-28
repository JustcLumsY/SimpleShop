namespace SimpleShop
{
    public class ShopItem
    {
        public string ItemName { get; set; }
        public int Price { get; set; }
        public string Id { get; set; }
        public ShopItem(string itemname, int price, string id)
        {
            ItemName = itemname;
            Price = price;  
            Id = id;    
        }      
    }
}
