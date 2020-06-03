using DOGobj.DomainObjects;
using DOGobj.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DOGobj.ApplicationServices.GetPlatformLightingListUseCase
{
    public class GetDOGobjListUseCaseResponse : UseCaseResponse
    {
        public IEnumerable<dogobj> DOGobjs { get; }

        public GetDOGobjListUseCaseResponse(IEnumerable<dogobj> dogobjs) => DOGobjs = dogobjs;
    }
}
