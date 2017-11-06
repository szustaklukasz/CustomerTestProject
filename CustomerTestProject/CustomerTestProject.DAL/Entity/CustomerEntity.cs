namespace CustomerTestProject.DAL.Entity
{
    public class CustomerEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string NIP { get; set; }
        public string Regon { get; set; }
        public string PhoneNumber { get; set; }

        public virtual AddressEntity Address { get; set; }
    }
}
