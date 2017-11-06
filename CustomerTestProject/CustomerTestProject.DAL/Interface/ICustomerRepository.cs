using CustomerTestProject.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerTestProject.DAL.Interface
{
    public interface ICustomerRepository
    {
        void Add(CustomerEntity entity);
        void Update(CustomerEntity entity);
        void Remove(int id);
        CustomerEntity Get(int id);
        IEnumerable<CustomerEntity> GetAll();
        void SaveChanges();
    }
}
