using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace DOGobj.DomainObjects.Ports
{
    public interface IReadOnlyDOGobjRepository
    {
        Task<dogobj> GetDOGobj(long id);

        Task<IEnumerable<dogobj>> GetAllDOGobjs();

        Task<IEnumerable<dogobj>> QueryDOGobjs(ICriteria<dogobj> criteria);

    }

    public interface IDOGobjRepository
    {
        Task AddDOGobj(dogobj dogobj);

        Task RemoveDOGobj(dogobj dogobj);

        Task UpdateDOGobj(dogobj dogobj);
    }
}
