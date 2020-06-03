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
        private readonly List<dogobj> _dogobjs = new List<dogobj>();

        public InMemoryDOGobjRepository(IEnumerable<dogobj> dogobjs = null)
        {
            if (dogobjs != null)
            {
                _dogobjs.AddRange(dogobjs);
            }
        }

        public Task AddDOGobj(dogobj dogobj)
        {
            _dogobjs.Add(dogobj);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<dogobj>> GetAllDOGobjs()
        {
            return Task.FromResult(_dogobjs.AsEnumerable());
        }

        public Task<dogobj> GetDOGobj(long id)
        {
            return Task.FromResult(_dogobjs.Where(pn => pn.Id == id).FirstOrDefault());
        }

        public Task<IEnumerable<dogobj>> QueryDOGobjs(ICriteria<dogobj> criteria)
        {
            return Task.FromResult(_dogobjs.Where(criteria.Filter.Compile()).AsEnumerable());
        }

        public Task RemoveDOGobj(dogobj dogobj)
        {
            _dogobjs.Remove(dogobj);
            return Task.CompletedTask;
        }

        public Task UpdateDOGobj(dogobj dogobj)
        {
            var foundDOGobj = GetDOGobj(dogobj.Id).Result;
            if (foundDOGobj == null)
            {
                AddDOGobj(dogobj);
            }
            else
            {
                if (foundDOGobj != dogobj)
                {
                    _dogobjs.Remove(foundDOGobj);
                    _dogobjs.Add(dogobj);
                }
            }
            return Task.CompletedTask;
        }
    }
}
