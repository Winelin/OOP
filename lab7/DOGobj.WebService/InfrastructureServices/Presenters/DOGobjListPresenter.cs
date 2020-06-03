using DOGobj.ApplicationServices.GetLightingListUseCase;
using System.Net;
using Newtonsoft.Json;
using DOGobj.ApplicationServices.Ports;

namespace DOGobj.InfrastructureServices.Presenters
{
    public class DOGobjListPresenter : IOutputPort<GetDOGobjListUseCaseResponse>
    {
        public JsonContentResult ContentResult { get; }

        public DOGobjListPresenter()
        {
            ContentResult = new JsonContentResult();
        }

        public void Handle(GetDOGobjListUseCaseResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.NotFound);
            ContentResult.Content = response.Success ? JsonConvert.SerializeObject(response.DOGobjs) : JsonConvert.SerializeObject(response.Message);
        }
    }
}
