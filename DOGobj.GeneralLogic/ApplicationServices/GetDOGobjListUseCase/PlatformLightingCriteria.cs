using DOGobj.DomainObjects;
using DOGobj.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DOGobj.ApplicationServices.GetPlatformLightingListUseCase
{
    public class PlatformLightingCriteria : ICriteria<dogobj>
    {
        public string PlatformLighting { get; }

        public PlatformLightingCriteria (string platformlighting)
            => PlatformLighting = platformlighting;

        public Expression<Func<dogobj, bool>> Filter
            => (b => b.Landmark == PlatformLighting);
    }
}
