using DOGobj.ApplicationServices.GetLightingListUseCase;
using DOGobj.ApplicationServices.Ports;
using DOGobj.DomainObjects;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;

namespace DOGobj.DesktopClient.InfrastructureServices.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly IGetDOGobjListUseCase _getDOGobjListUseCase;

        public MainViewModel(IGetDOGobjListUseCase getDOGobjListUseCase)
            => _getDOGobjListUseCase = getDOGobjListUseCase;

        private Task<bool> _loadingTask;
        private dogobj _currentDOGobj;
        private ObservableCollection<dogobj> _dogobjs;

        public event PropertyChangedEventHandler PropertyChanged;

        public dogobj CurrentDOGobj
        {
            get => _currentDOGobj; 
            set
            {
                if (_currentDOGobj != value)
                {
                    _currentDOGobj = value;
                    OnPropertyChanged(nameof(CurrentDOGobj));
                }
            }
        }

        private async Task<bool> LoadDOGobjs()
        {
            var outputPort = new OutputPort();
            bool result = await _getDOGobjListUseCase.Handle(GetDOGobjListUseCaseRequest.CreateAllDOGobjsRequest(), outputPort);
            if (result)
            {
                DOGobjs = new ObservableCollection<dogobj>(outputPort.DOGobjs);
            }
            return result;
        }

        public ObservableCollection<dogobj> DOGobjs
        {
            get 
            {
                if (_loadingTask == null)
                {
                    _loadingTask = LoadDOGobjs();
                }
                
                return _dogobjs; 
            }
            set
            {
                if (_dogobjs != value)
                {
                    _dogobjs = value;
                    OnPropertyChanged(nameof(DOGobjs));
                }
            }
        }

        private void OnPropertyChanged(string propertyDepartamentalAffiliation)
        {
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyDepartamentalAffiliation));
        }

        private class OutputPort : IOutputPort<GetDOGobjListUseCaseResponse>
        {
            public IEnumerable<dogobj> DOGobjs { get; private set; }

            public void Handle(GetDOGobjListUseCaseResponse response)
            {
                if (response.Success)
                {
                    DOGobjs = new ObservableCollection<dogobj>(response.DOGobjs);
                }
            }
        }
    }
}
