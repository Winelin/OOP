using DOGobj.DomainObjects;
using DOGobj.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DOGobj.DomainObjects.Repositories
{
    public abstract class ReadOnlyDOGobjRepositoryDecorator : IReadOnlyDOGobjRepository
    {
        private readonly IReadOnlyDOGobjRepository _dogobjRepository;

        public ReadOnlyDOGobjRepositoryDecorator(IReadOnlyDOGobjRepository dogobjRepository)
        {
            _dogobjRepository = dogobjRepository;
        }

        public virtual async Task<IEnumerable<dogobj>> GetAllDOGobjs()
        {
            return await _dogobjRepository?.GetAllDOGobjs();
        }

        public virtual async Task<dogobj> GetDOGobj(long id)
        {
            return await _dogobjRepository?.GetDOGobj(id);
        }

        public virtual async Task<IEnumerable<dogobj>> QueryDOGobjs(ICriteria<dogobj> criteria)
        {
            return await _dogobjRepository?.QueryDOGobjs(criteria);
        }
    }
}
