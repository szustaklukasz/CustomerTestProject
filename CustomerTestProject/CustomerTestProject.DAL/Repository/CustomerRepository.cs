using CustomerTestProject.DAL.Context;
using CustomerTestProject.DAL.Interface;
using System;
using System.Collections.Generic;
using CustomerTestProject.DAL.Entity;
using System.Linq;

namespace CustomerTestProject.DAL.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DatabaseContext _context;

        public CustomerRepository(DatabaseContext context)
        {
            _context = context;
        }

        public void Add(CustomerEntity entity)
        {
            _context.Customers.Add(entity);
        }

        public CustomerEntity Get(int id)
        {
            return _context.Customers.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<CustomerEntity> GetAll()
        {
            return _context.Customers.ToList();
        }

        public void Remove(int id)
        {
            CustomerEntity customer = _context.Customers.SingleOrDefault(x => x.Id == id);
            if (customer == null)
                throw new InvalidOperationException("Cannot delete customer");

            _context.Customers.Remove(customer);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(CustomerEntity entity)
        {
            _context.Customers.Update(entity);
        }
    }
}
