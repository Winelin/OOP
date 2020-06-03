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

        public async Task<dogobj> GetDOGobj(long id)
            => await _databaseGateway.GetDOGobj(id);

        public async Task<IEnumerable<dogobj>> GetAllDOGobjs()
            => await _databaseGateway.GetAllDOGobjs();

        public async Task<IEnumerable<dogobj>> QueryDOGobjs(ICriteria<dogobj> criteria)
            => await _databaseGateway.QueryDOGobjs(criteria.Filter);

        public async Task AddDOGobj(dogobj dogobj)
            => await _databaseGateway.AddDOGobj(dogobj);

        public async Task RemoveDOGobj(dogobj dogobj)
            => await _databaseGateway.RemoveDOGobj(dogobj);

        public async Task UpdateDOGobj(dogobj dogobj)
            => await _databaseGateway.UpdateDOGobj(dogobj);
    }
}
