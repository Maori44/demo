using DemoData.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.DomainRepository
{
    public interface IDomainRepository
    {
        IEnumerable<DomainVM> GetDomains();

        DomainVM deleteDomain(int id);

    }
}
