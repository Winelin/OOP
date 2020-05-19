using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace DOGobj.DomainObjects.Ports
{
    public interface IReadOnlyDOGobjRepository
    {
        Task<DOGobj> GetDOGobj(long id);

        Task<IEnumerable<DOGobj>> GetAllDOGobjs();

        Task<IEnumerable<DOGobj>> QueryDOGobj(ICriteria<DOGobj> criteria);

    }

    public interface IDOGobjRepository
    {
        Task AddDOGobj(DOGobj dogObj);

        Task RemoveDOGobj(DOGobj dogObj);

        Task UpdateDOGobj(DOGobj dogObj);
    }
}
