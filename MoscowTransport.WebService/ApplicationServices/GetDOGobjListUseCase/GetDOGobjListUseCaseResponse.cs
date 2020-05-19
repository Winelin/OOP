using DOGobj.DomainObjects;
using DOGobj.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DOGobj.ApplicationServices.GetDOGobjListUseCase
{
    public class GetDOGobjListUseCaseResponse : UseCaseResponse
    {
        public IEnumerable<DomainObjects.DOGobj> DOGobj { get; }

        public GetDOGobjListUseCaseResponse(IEnumerable<DomainObjects.DOGobj> dogObj) => DOGobj = dogObj;
    }
}
