namespace CustomerTestProject.DAL.Entity
{
    public class AddressEntity
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Street{ get; set; }
        public string Country { get; set; }
        public string HouseNumber { get; set; }
        public string LocalNumber { get; set; }

        public virtual CustomerEntity Customer { get; set; }
    }
}
