using DOGobj.DomainObjects;
using DOGobj.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DOGobj.ApplicationServices.GetLightingListUseCase
{
    public class LightingCriteria : ICriteria<dogobj>
    {
        public string Lighting { get; }

        public LightingCriteria (string lighting)
            => Lighting = lighting;

        public Expression<Func<dogobj, bool>> Filter
            => (b => b.Location == Lighting);
    }
}
