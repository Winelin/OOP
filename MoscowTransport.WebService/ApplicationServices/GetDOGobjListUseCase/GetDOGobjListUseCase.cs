using System.Threading.Tasks;
using System.Collections.Generic;
using DOGobj.DomainObjects;
using DOGobj.DomainObjects.Ports;
using DOGobj.ApplicationServices.Ports;

namespace DOGobj.ApplicationServices.GetDOGobjListUseCase
{
    public class GetDOGobjListUseCase : IGetDOGobjListUseCase
    {
        private readonly IReadOnlyDOGobjRepository _readOnlyDOGobjRepository;

        public GetDOGobjListUseCase(IReadOnlyDOGobjRepository readOnlyDOGobjRepository) 
            => _readOnlyDOGobjRepository = readOnlyDOGobjRepository;

        public async Task<bool> Handle(GetDOGobjListUseCaseRequest request, IOutputPort<GetDOGobjListUseCaseResponse> outputPort)
        {
            IEnumerable<DomainObjects.DOGobj> dogObjs = null;
            if (request.DOGobjId != null)
            {
                var dogObj = await _readOnlyDOGobjRepository.GetDOGobj(request.DOGobjId.Value);
                dogObjs = (dogObj != null) ? new List<DomainObjects.DOGobj>() { dogObj } : new List<DomainObjects.DOGobj>();
                
            }
            else if (request.Landmark != null)
            {
                dogObjs = await _readOnlyDOGobjRepository.QueryDOGobj(new LandmarkCriteria(request.Landmark));
            }
            else
            {
                dogObjs = await _readOnlyDOGobjRepository.GetAllDOGobjs();
            }
            outputPort.Handle(new GetDOGobjListUseCaseResponse(dogObjs));
            return true;
        }
    }
}
