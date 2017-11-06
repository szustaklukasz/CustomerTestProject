using AutoMapper;
using CustomerTestProject.DAL.Entity;
using CustomerTestProject.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerTestProject.Infrastructure.Utility
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<CustomerEntity, CustomerDTO>().ReverseMap();
                cfg.CreateMap<AddressEntity, AddressDTO>().ReverseMap();
            });
        }
    }
}
