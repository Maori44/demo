using AutoMapper;
using Demo.DomainRepository;
using DemoData.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Controllers
{
    [Route("api/[controller]")]
    public class DomainController : Controller
    {
        private readonly IMapper mapper;
        private readonly IDomainRepository domainRepository;

        public DomainController(IMapper mapper, IDomainRepository domainRepository)
        {
            this.mapper = mapper;
            this.domainRepository = domainRepository;
        }
        [EnableCors("Policy1")]
        [HttpGet]
        public IActionResult Get()
        {
            var domainData = this.domainRepository.GetDomains();
            return Ok(domainData);
        }
        [EnableCors("Policy1")]
        [Route("{Id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            this.domainRepository.deleteDomain(id);
            return Ok(true);
        }
    }
}
