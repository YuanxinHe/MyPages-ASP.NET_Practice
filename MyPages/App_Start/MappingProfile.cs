using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MyPages.DTOs;
using MyPages.Models;

namespace MyPages.App_Start
{
    //This class uses for determination of how ojects with different types can be mapped to each others.
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}