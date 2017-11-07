﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerTestProject.Infrastructure.DTO
{
    public class AddressDTO
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Country { get; set; }
        public string HouseNumber { get; set; }
        public string LocalNumber { get; set; }
    }
}
