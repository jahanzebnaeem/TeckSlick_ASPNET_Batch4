namespace Teckslick.Batch4.Common
{
    public class Address
    {
        public int AddressID { get; set; }
        public string CompleteAddress { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }
    }
}