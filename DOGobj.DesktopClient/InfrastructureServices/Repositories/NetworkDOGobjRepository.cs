using DOGobj.ApplicationServices.Ports.Cache;
using DOGobj.DomainObjects;
using DOGobj.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DOGobj.InfrastructureServices.Repositories
{
    public class NetworkDOGobjRepository : NetworkRepositoryBase, IReadOnlyDOGobjRepository
    {
        private readonly IDomainObjectsCache<dogobj> _dogobjCache;

        public NetworkDOGobjRepository(string host, ushort port, bool useTls, IDomainObjectsCache<dogobj> dogobjCache)
            : base(host, port, useTls)
            => _dogobjCache = dogobjCache;

        public async Task<dogobj> GetDOGobj(long id)
            => CacheAndReturn(await ExecuteHttpRequest<dogobj>($"dogobjs/{id}"));

        public async Task<IEnumerable<dogobj>> GetAllDOGobjs()
            => CacheAndReturn(await ExecuteHttpRequest<IEnumerable<dogobj>>($"dogobjs"), allObjects: true);

        public async Task<IEnumerable<dogobj>> QueryDOGobjs(ICriteria<dogobj> criteria)
            => CacheAndReturn(await ExecuteHttpRequest<IEnumerable<dogobj>>($"dogobjs"), allObjects: true)
               .Where(criteria.Filter.Compile());


        private IEnumerable<dogobj> CacheAndReturn(IEnumerable<dogobj> dogobjs, bool allObjects = false)
        {
            if (allObjects)
            {
                _dogobjCache.ClearCache();
            }
            _dogobjCache.UpdateObjects(dogobjs, DateTime.Now.AddDays(1), allObjects);
            return dogobjs;
        }

        private dogobj CacheAndReturn(dogobj dogobj)
        {
            _dogobjCache.UpdateObject(dogobj, DateTime.Now.AddDays(1));
            return dogobj;
        }
    }
}
