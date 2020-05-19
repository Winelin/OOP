using DOGobj.DomainObjects;
using DOGobj.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DOGobj.ApplicationServices.GetDOGobjListUseCase
{
    public class LandmarkCriteria : ICriteria<DomainObjects.DOGobj>
    {
        public string Landmark { get; }      /*save filtration criteria*/

        public LandmarkCriteria(string landmark) /*get criteria and save as class member*/
            => Landmark = landmark;

        public Expression<Func<DomainObjects.DOGobj, bool>> Filter
            => (dog => dog.Landmark == Landmark); /*Filter*/
    }
}
