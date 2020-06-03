using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DOGobj.DomainObjects;
using DOGobj.ApplicationServices.GetLightingListUseCase;
using DOGobj.InfrastructureServices.Presenters;

namespace DOGobj.InfrastructureServices.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DOGobjsController : ControllerBase
    {
        private readonly ILogger<DOGobjsController> _logger;
        private readonly IGetDOGobjListUseCase _getDOGobjListUseCase;

        public DOGobjsController(ILogger<DOGobjsController> logger,
                                IGetDOGobjListUseCase getDOGobjListUseCase)
        {
            _logger = logger;
            _getDOGobjListUseCase = getDOGobjListUseCase;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllDOGobjs()
        {
            var presenter = new DOGobjListPresenter();
            await _getDOGobjListUseCase.Handle(GetDOGobjListUseCaseRequest.CreateAllDOGobjsRequest(), presenter);
            return presenter.ContentResult;
        }

        [HttpGet("{dogobjId}")]
        public async Task<ActionResult> GetDOGobj(long dogobjId)
        {
            var presenter = new DOGobjListPresenter();
            await _getDOGobjListUseCase.Handle(GetDOGobjListUseCaseRequest.CreateDOGobjRequest(dogobjId), presenter);
            return presenter.ContentResult;
        }

        [HttpGet("lighting/{lighting}")]
        public async Task<ActionResult> GetLightingDOGobjs(string lighting)
        {
            var presenter = new DOGobjListPresenter();
            await _getDOGobjListUseCase.Handle(GetDOGobjListUseCaseRequest.CreateDOGobjsRequest(lighting), presenter);
            return presenter.ContentResult;
        }
    }
}
