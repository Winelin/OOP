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
        Task AddDOGobj(dogobj dogobj);

        Task RemoveDOGobj(dogobj dogobj);

        Task UpdateDOGobj(dogobj dogobj);

        Task<dogobj> GetDOGobj(long id);

        Task<IEnumerable<dogobj>> GetAllDOGobjs();

        Task<IEnumerable<dogobj>> QueryDOGobjs(Expression<Func<dogobj, bool>> filter);

    }
}
