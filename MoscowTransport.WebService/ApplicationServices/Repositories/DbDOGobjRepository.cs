using DOGobj.ApplicationServices.Ports.Gateways.Database;
using DOGobj.DomainObjects;
using DOGobj.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DOGobj.ApplicationServices.Repositories
{
    public class DbDOGobjRepository : IReadOnlyDOGobjRepository,
                                     IDOGobjRepository
    {
        private readonly IDOGobjDatabaseGateway _databaseGateway;

        public DbDOGobjRepository(IDOGobjDatabaseGateway databaseGateway)
            => _databaseGateway = databaseGateway;

        public async Task<DomainObjects.DOGobj> GetDOGobj(long id)
            => await _databaseGateway.GetDOGobj(id);

        public async Task<IEnumerable<DomainObjects.DOGobj>> GetAllDOGobjs()
            => await _databaseGateway.GetAllDOGobj();

        public async Task<IEnumerable<DomainObjects.DOGobj>> QueryDOGobj(ICriteria<DomainObjects.DOGobj> criteria)
            => await _databaseGateway.QueryDOGobj(criteria.Filter);

        public async Task AddDOGobj(DomainObjects.DOGobj dogObj)
            => await _databaseGateway.AddDOGobj(dogObj);

        public async Task RemoveDOGobj(DomainObjects.DOGobj dogObj)
            => await _databaseGateway.RemoveDOGobj(dogObj);

        public async Task UpdateDOGobj(DomainObjects.DOGobj dogObj)
            => await _databaseGateway.UpdateDOGobj(dogObj);
    }
}
