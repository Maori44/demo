using AutoMapper;
using Demo.Repository;
using DemoData.Models;
using DemoData.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.DomainRepository
{
    public class SQLDomainRepository : IDomainRepository
    {

        private readonly DemoContext dbContext;
        private readonly IMapper mapper;

        public SQLDomainRepository(DemoContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
      
        public DomainVM deleteDomain(int id)
        {
            var user = dbContext.tbl_toll.Find(id);

            if (user != null)
            {
                dbContext.tbl_toll.Remove(user);
                dbContext.SaveChanges();
            }

            return mapper.Map<DomainVM>(user);
        }
        
        public IEnumerable<DomainVM> GetDomains()
        {
            return mapper.Map<List<DomainVM>>(dbContext.tbl_toll);
        }
    }
}
