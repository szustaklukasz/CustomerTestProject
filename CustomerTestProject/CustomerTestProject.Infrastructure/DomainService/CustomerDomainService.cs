using CustomerTestProject.DAL.Interface;
using CustomerTestProject.Infrastructure.Interface;
using System.Collections.Generic;
using CustomerTestProject.Infrastructure.DTO;
using AutoMapper;
using CustomerTestProject.DAL.Entity;

namespace CustomerTestProject.Infrastructure.DomainService
{
    public class CustomerDomainService : ICustomerDomainService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerDomainService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void Add(CustomerDTO dto)
        {
            var entity = Mapper.Map<CustomerEntity>(dto);
            _customerRepository.Add(entity);
            _customerRepository.SaveChanges();
        }

        public CustomerDTO Get(int id)
        {
            var entity = _customerRepository.Get(id);
            return Mapper.Map<CustomerDTO>(entity);
        }

        public IEnumerable<CustomerDTO> GetAll()
        {
            var entities = _customerRepository.GetAll();
            return Mapper.Map<IEnumerable<CustomerDTO>>(entities);
        }

        public void Remove(int id)
        {
            _customerRepository.Remove(id);
            _customerRepository.SaveChanges();
        }

        public void Update(CustomerDTO dto)
        {
            var customerEntity = Mapper.Map<CustomerEntity>(dto);
            _customerRepository.Update(customerEntity);
            _customerRepository.SaveChanges();
        }
    }
}
