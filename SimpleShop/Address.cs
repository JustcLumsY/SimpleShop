namespace SimpleShop
{
    public class Address
    {
        public string RoadName { get; set; }
        public string HouseNumber { get; set; }
        public Address(string roadname, string housenumber)
        {
            RoadName = roadname;
            HouseNumber = housenumber;
        }   
    }
}
