namespace SimpleShop
{
    public class Customer
    {
        public string Name { get; set; }    
        public Address Address {get;set;}
        public BankInformation BankInformation {get;set;}

        public Customer(string name, Address address, BankInformation bankinfo)
        {             
            Address = address;
            BankInformation = bankinfo;
        }
    }
}
