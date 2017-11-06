using CustomerTestProject.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerTestProject.Infrastructure.Interface
{
    public interface ICustomerDomainService
    {
        void Add(CustomerDTO dto);
        void Update(CustomerDTO dto);
        CustomerDTO Get(int id);
        IEnumerable<CustomerDTO> GetAll();
        void Remove(int id);
    }
}
