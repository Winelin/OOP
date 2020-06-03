using DOGobj.DomainObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Xunit;
using DOGobj.ApplicationServices.GetPlatformLightingListUseCase;
using System.Linq.Expressions;
using DOGobj.ApplicationServices.Ports;
using DOGobj.DomainObjects.Ports;
using DOGobj.ApplicationServices.Repositories;

namespace DOGobj.WebService.Core.Tests
{
    public class GetDOGobjListUseCaseTest
    {
        private InMemoryDOGobjRepository CreateDOGobjRepository()
        {
            var repo = new InMemoryDOGobjRepository(new List<dogobj> {
                new dogobj { Id = 1, Landmark = "Библиотека имени Ленина", Name = "Успенский собор"},
                new dogobj { Id = 2, Landmark = "Библиотека имени Ленина", Name = "Архангельский собор"},
                new dogobj { Id = 3, Landmark = "Библиотека имени Ленина", Name = "Благовещенский собор"},
                new dogobj { Id = 4, Landmark = "Библиотека имени Ленина", Name = "Патриаршие палаты с церковью Двенадцати апостолов"},
            });
            return repo;
        }
        [Fact]
        public void TestGetAllDOGobj()
        {
            var useCase = new GetDOGobjListUseCase(CreateDOGobjRepository());
            var outputPort = new OutputPort();
                        
            Assert.True(useCase.Handle(GetDOGobjListUseCaseRequest.CreateAllDOGobjsRequest(), outputPort).Result);
            Assert.Equal<int>(4, outputPort.DOGobjs.Count());
            Assert.Equal(new long[] { 1, 2, 3, 4 }, outputPort.DOGobjs.Select(mp => mp.Id));
        }

        [Fact]
        public void TestGetAllDOGobjsFromEmptyRepository()
        {
            var useCase = new GetDOGobjListUseCase(new InMemoryDOGobjRepository());
            var outputPort = new OutputPort();

            Assert.True(useCase.Handle(GetDOGobjListUseCaseRequest.CreateAllDOGobjsRequest(), outputPort).Result);
            Assert.Empty(outputPort.DOGobjs);
        }

        [Fact]
        public void TestGetDOGobj()
        {
            var useCase = new GetDOGobjListUseCase(CreateDOGobjRepository());
            var outputPort = new OutputPort();

            Assert.True(useCase.Handle(GetDOGobjListUseCaseRequest.CreateDOGobjRequest(2), outputPort).Result);
            Assert.Single(outputPort.DOGobjs, pn => 2 == pn.Id);
        }

        [Fact]
        public void TestTryGetNotExistingDOGobj()
        {
            var useCase = new GetDOGobjListUseCase(CreateDOGobjRepository());
            var outputPort = new OutputPort();

            Assert.True(useCase.Handle(GetDOGobjListUseCaseRequest.CreateDOGobjRequest(999), outputPort).Result);
            Assert.Empty(outputPort.DOGobjs);
        }
      
    }

    class OutputPort : IOutputPort<GetDOGobjListUseCaseResponse>
    {
        public IEnumerable<dogobj> DOGobjs { get; private set; }

        public void Handle(GetDOGobjListUseCaseResponse response)
        {
            DOGobjs = response.DOGobjs;
        }
    }
}
