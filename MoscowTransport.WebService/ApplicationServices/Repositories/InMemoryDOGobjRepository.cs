using DOGobj.DomainObjects;
using DOGobj.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DOGobj.ApplicationServices.Repositories
{
    public class InMemoryDOGobjRepository : IReadOnlyDOGobjRepository,
                                             IDOGobjRepository 
    {
        private readonly List<DomainObjects.DOGobj> _dogObjs = new List<DomainObjects.DOGobj>();

        public InMemoryDOGobjRepository(IEnumerable<DomainObjects.DOGobj> dogObjs = null)
        {
            if (dogObjs != null)
            {
                _dogObjs.AddRange(dogObjs);
            }
        }

        public Task AddDOGobj(DomainObjects.DOGobj dogObj)
        {
            _dogObjs.Add(dogObj);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<DomainObjects.DOGobj>> GetAllDOGobjs()
        {
            return Task.FromResult(_dogObjs.AsEnumerable());
        }

        public Task<DomainObjects.DOGobj> GetDOGobj(long id)
        {
            return Task.FromResult(_dogObjs.Where(r => r.Id == id).FirstOrDefault());
        }

        public Task<IEnumerable<DomainObjects.DOGobj>> QueryDOGobj(ICriteria<DomainObjects.DOGobj> criteria)
        {
            return Task.FromResult(_dogObjs.Where(criteria.Filter.Compile()).AsEnumerable());
        }

        public Task RemoveDOGobj(DomainObjects.DOGobj dogObj)
        {
            _dogObjs.Remove(dogObj);
            return Task.CompletedTask;
        }

        public Task UpdateDOGobj(DomainObjects.DOGobj dogObj)
        {
            var foundDOGobj = GetDOGobj(dogObj.Id).Result;
            if (foundDOGobj == null)
            {
                AddDOGobj(dogObj);
            }
            else
            {
                if (foundDOGobj != dogObj)
                {
                    _dogObjs.Remove(foundDOGobj);
                    _dogObjs.Add(dogObj);
                }
            }
            return Task.CompletedTask;
        }
    }
}
