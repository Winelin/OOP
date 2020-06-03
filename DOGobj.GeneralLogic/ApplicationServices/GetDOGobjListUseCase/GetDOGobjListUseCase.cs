using System.Threading.Tasks;
using System.Collections.Generic;
using DOGobj.DomainObjects;
using DOGobj.DomainObjects.Ports;
using DOGobj.ApplicationServices.Ports;

namespace DOGobj.ApplicationServices.GetPlatformLightingListUseCase
{
    public class GetDOGobjListUseCase : IGetDOGobjListUseCase
    {
        private readonly IReadOnlyDOGobjRepository _readOnlyDOGobjRepository;

        public GetDOGobjListUseCase(IReadOnlyDOGobjRepository readOnlyDOGobjRepository) 
            => _readOnlyDOGobjRepository = readOnlyDOGobjRepository;
        
        public async Task<bool> Handle(GetDOGobjListUseCaseRequest request, IOutputPort<GetDOGobjListUseCaseResponse> outputPort)
        {
            IEnumerable<dogobj> dogobjs = null;
            if (request.DOGobjId != null)
            {
                var dogobj = await _readOnlyDOGobjRepository.GetDOGobj(request.DOGobjId.Value);
                dogobjs = (dogobj != null) ? new List<dogobj>() { dogobj } : new List<dogobj>();
                
            }
            else if (request.PlatformLighting != null)
            {
                dogobjs = await _readOnlyDOGobjRepository.QueryDOGobjs(new PlatformLightingCriteria(request.PlatformLighting));
            }
            else
            {
                dogobjs = await _readOnlyDOGobjRepository.GetAllDOGobjs();
            }
            outputPort.Handle(new GetDOGobjListUseCaseResponse(dogobjs));
            return true;
        }
    }
}
