using DOGobj.ApplicationServices.Ports.Cache;
using DOGobj.DomainObjects;
using DOGobj.DomainObjects.Ports;
using DOGobj.DomainObjects.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DOGobj.ApplicationServices.Repositories
{
    public class CachedReadOnlyDOGobjRepository : ReadOnlyDOGobjRepositoryDecorator
    {
        private readonly IDomainObjectsCache<dogobj> _dogobjsCache;

        public CachedReadOnlyDOGobjRepository(IReadOnlyDOGobjRepository dogobjRepository, 
                                             IDomainObjectsCache<dogobj> dogobjsCache)
            : base(dogobjRepository)
            => _dogobjsCache = dogobjsCache;

        public async override Task<dogobj> GetDOGobj(long id)
            => _dogobjsCache.GetObject(id) ?? await base.GetDOGobj(id);

        public async override Task<IEnumerable<dogobj>> GetAllDOGobjs()
            => _dogobjsCache.GetObjects() ?? await base.GetAllDOGobjs();

        public async override Task<IEnumerable<dogobj>> QueryDOGobjs(ICriteria<dogobj> criteria)
            => _dogobjsCache.GetObjects()?.Where(criteria.Filter.Compile()) ?? await base.QueryDOGobjs(criteria);

    }
}
