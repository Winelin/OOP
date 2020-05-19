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
        private readonly DOGobjContext _dogObjContext;

        public DOGobjEFSqliteGateway(DOGobjContext dogObjContext)
            => _dogObjContext = dogObjContext;

        public async Task<DomainObjects.DOGobj> GetDOGobj(long id)
           => await _dogObjContext.DOGobjs.FirstOrDefaultAsync();

        public async Task<IEnumerable<DomainObjects.DOGobj>> GetAllDOGobj()
            => await _dogObjContext.DOGobjs.ToListAsync();
          
        public async Task<IEnumerable<DomainObjects.DOGobj>> QueryDOGobj(Expression<Func<DomainObjects.DOGobj, bool>> filter)
            => await _dogObjContext.DOGobjs.Where(filter).ToListAsync();

        public async Task AddDOGobj(DomainObjects.DOGobj dogObj)
        {
            _dogObjContext.DOGobjs.Add(dogObj);
            await _dogObjContext.SaveChangesAsync();
        }

        public async Task UpdateDOGobj(DomainObjects.DOGobj dogobj)
        {
            _dogObjContext.Entry(dogobj).State = EntityState.Modified;
            await _dogObjContext.SaveChangesAsync();
        }

        public async Task RemoveDOGobj(DomainObjects.DOGobj dogobj)
        {
            _dogObjContext.DOGobjs.Remove(dogobj);
            await _dogObjContext.SaveChangesAsync();
        }


       
    }
}
