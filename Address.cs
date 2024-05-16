namespace LinquHomeWork
{
    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public int NumberHouse { get; set; }
        public Address(string city, string street, int numberHouse)
        {
            City = city;
            Street = street;
            NumberHouse = numberHouse;

        }

        public override string ToString()
        {
            return $"{City}, {Street}, {NumberHouse}";
        }
    }
}
