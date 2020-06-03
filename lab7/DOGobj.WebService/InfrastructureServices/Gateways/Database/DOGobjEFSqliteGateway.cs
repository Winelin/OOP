using DOGobj.DomainObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using DOGobj.ApplicationServices.Ports.Gateways.Database;

namespace DOGobj.InfrastructureServices.Gateways.Database
{
    public class DOGobjEFSqliteGateway : IDOGobjDatabaseGateway
    {
        private readonly DOGobjContext _dogobjContext;

        public DOGobjEFSqliteGateway(DOGobjContext DOGobjContext)
            => _dogobjContext = DOGobjContext;

        public async Task<dogobj> GetDOGobj(long id)
           => await _dogobjContext.DOGobjs.Where(b => b.Id == id).FirstOrDefaultAsync();

        public async Task<IEnumerable<dogobj>> GetAllDOGobjs()
            => await _dogobjContext.DOGobjs.ToListAsync();
          
        public async Task<IEnumerable<dogobj>> QueryDOGobjs(Expression<Func<dogobj, bool>> filter)
            => await _dogobjContext.DOGobjs.Where(filter).ToListAsync();

        public async Task AddDOGobj(dogobj dogobj)
        {
            _dogobjContext.DOGobjs.Add(dogobj);
            await _dogobjContext.SaveChangesAsync();
        }

        public async Task UpdateDOGobj(dogobj dogobj)
        {
            _dogobjContext.Entry(dogobj).State = EntityState.Modified;
            await _dogobjContext.SaveChangesAsync();
        }

        public async Task RemoveDOGobj(dogobj dogobj)
        {
            _dogobjContext.DOGobjs.Remove(dogobj);
            await _dogobjContext.SaveChangesAsync();
        }

    }
}
