using DOGobj.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DOGobj.ApplicationServices.Ports.Gateways.Database
{
    public interface IDOGobjDatabaseGateway
    {
        Task AddDOGobj(DomainObjects.DOGobj dogObj);

        Task RemoveDOGobj(DomainObjects.DOGobj dogObj);

        Task UpdateDOGobj(DomainObjects.DOGobj dogObj);

        Task<DomainObjects.DOGobj> GetDOGobj(long id);

        Task<IEnumerable<DomainObjects.DOGobj>> GetAllDOGobj();

        Task<IEnumerable<DomainObjects.DOGobj>> QueryDOGobj(Expression<Func<DomainObjects.DOGobj, bool>> filter);

    }
}
