using DOGobj.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DOGobj.ApplicationServices.GetDOGobjListUseCase
{
    public class GetDOGobjListUseCaseRequest : IUseCaseRequest<GetDOGobjListUseCaseResponse>
    {
        public string Landmark { get; private set; }
        public long? DOGobjId { get; private set; }

        private GetDOGobjListUseCaseRequest()
        { }

        public static GetDOGobjListUseCaseRequest CreateAllDOGobjRequest()
        {
            return new GetDOGobjListUseCaseRequest();
        }

        public static GetDOGobjListUseCaseRequest CreateDOGobjRequest(long dogObjId)
        {
            return new GetDOGobjListUseCaseRequest() { DOGobjId = dogObjId };
        }
        public static GetDOGobjListUseCaseRequest CreateLandmarkDOGobjRequest(string dogObjs)
        {
            return new GetDOGobjListUseCaseRequest() { Landmark = dogObjs };
        }
    }
}
