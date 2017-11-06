using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerTestProject.Infrastructure.DTO
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string NIP { get; set; }
        public string Regon { get; set; }
        public string PhoneNumber { get; set; }

        public AddressDTO Address { get; set; }
    }
}
