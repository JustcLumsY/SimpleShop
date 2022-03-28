namespace SimpleShop
{
    public class BankInformation
    {
        public string BankName { get; set; }
        public string CardNumber { get; set; }
        public int Balance  { get; set; }
        public string Currency { get; set; }

        public BankInformation(string bankname, string cardnumber, int balance, string currency)
        {
            BankName = bankname;
            CardNumber = cardnumber;
            Balance = balance;
            Currency = currency;
        }
    }
}
