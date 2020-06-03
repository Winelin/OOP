using DOGobj.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DOGobj.ApplicationServices.GetPlatformLightingListUseCase
{
    public class GetDOGobjListUseCaseRequest : IUseCaseRequest<GetDOGobjListUseCaseResponse>
    {
        public string PlatformLighting { get; private set; }
        public long? DOGobjId { get; private set; }

        private GetDOGobjListUseCaseRequest()
        { }

        public static GetDOGobjListUseCaseRequest CreateAllDOGobjsRequest()
        {
            return new GetDOGobjListUseCaseRequest();
        }

        public static GetDOGobjListUseCaseRequest CreateDOGobjRequest(long dogobjId)
        {
            return new GetDOGobjListUseCaseRequest() { DOGobjId = dogobjId };
        }
        public static GetDOGobjListUseCaseRequest CreateDOGobjsRequest(string platformlighting)
        {
            return new GetDOGobjListUseCaseRequest() { PlatformLighting = platformlighting };
        }
    }
}
