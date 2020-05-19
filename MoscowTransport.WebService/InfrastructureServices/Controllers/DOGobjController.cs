using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DOGobj.DomainObjects;
using DOGobj.ApplicationServices.GetDOGobjListUseCase;
using DOGobj.InfrastructureServices.Presenters;

namespace DOGobj.InfrastructureServices.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DOGobjController : ControllerBase
    {
        private readonly ILogger<DOGobjController> _logger;
        private readonly IGetDOGobjListUseCase _getDOGobjListUseCase;

        public DOGobjController(ILogger<DOGobjController> logger,
                                IGetDOGobjListUseCase getDOGobjListUseCase)
        {
            _logger = logger;
            _getDOGobjListUseCase = getDOGobjListUseCase;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllDOGobj()
        {
            var presenter = new DOGobjListPresenter();
            await _getDOGobjListUseCase.Handle(GetDOGobjListUseCaseRequest.CreateAllDOGobjRequest(), presenter);
            return presenter.ContentResult;
        }

        [HttpGet("{dogObjId}")]
        public async Task<ActionResult> GetDOGobj(long dogObjId)
        {
            var presenter = new DOGobjListPresenter();
            await _getDOGobjListUseCase.Handle(GetDOGobjListUseCaseRequest.CreateDOGobjRequest(dogObjId), presenter);
            return presenter.ContentResult;
        }

        [HttpGet("Landmarks/{landmark}")]
        public async Task<ActionResult> GetLandmarkFilter(string landmark)
        {
            var presenter = new DOGobjListPresenter();
            await _getDOGobjListUseCase.Handle(GetDOGobjListUseCaseRequest.CreateLandmarkDOGobjRequest(landmark), presenter);
            return presenter.ContentResult;
        }
    }
}
