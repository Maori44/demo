using AutoMapper;
using DemoData.Models;
using DemoData.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
           CreateMap<Domain, DomainVM>().ReverseMap();
        }
    }
}
