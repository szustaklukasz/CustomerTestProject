using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CustomerTestProject.Infrastructure.Interface;
using CustomerTestProject.Infrastructure.DTO;

namespace CustomerTestProject.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private readonly ICustomerDomainService _customerDomainService;

        public CustomerController(ICustomerDomainService customerDomainService)
        {
            _customerDomainService = customerDomainService;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<CustomerDTO> Get()
        {
            return _customerDomainService.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public CustomerDTO Get(int id)
        {
            return _customerDomainService.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]CustomerDTO dto)
        {
            _customerDomainService.Add(dto);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]CustomerDTO dto)
        {
            _customerDomainService.Update(dto);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _customerDomainService.Remove(id);
        }
    }
}
