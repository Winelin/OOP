using Microsoft.Extensions.DependencyInjection;
using DOGobj.ApplicationServices.GetLightingListUseCase;
using DOGobj.ApplicationServices.Ports.Cache;
using DOGobj.ApplicationServices.Repositories;
using DOGobj.DesktopClient.InfrastructureServices.ViewModels;
using DOGobj.DomainObjects;
using DOGobj.DomainObjects.Ports;
using DOGobj.InfrastructureServices.Cache;
using DOGobj.InfrastructureServices.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DOGobj.DesktopClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;

        public App()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IDomainObjectsCache<dogobj>, DomainObjectsMemoryCache<dogobj>>();
            services.AddSingleton<NetworkDOGobjRepository>(
                x => new NetworkDOGobjRepository("localhost", 80, useTls: false, x.GetRequiredService<IDomainObjectsCache<dogobj>>())
            );
            services.AddSingleton<CachedReadOnlyDOGobjRepository>(
                x => new CachedReadOnlyDOGobjRepository(
                    x.GetRequiredService<NetworkDOGobjRepository>(), 
                    x.GetRequiredService<IDomainObjectsCache<dogobj>>()
                )
            );
            services.AddSingleton<IReadOnlyDOGobjRepository>(x => x.GetRequiredService<CachedReadOnlyDOGobjRepository>());
            services.AddSingleton<IGetDOGobjListUseCase, GetDOGobjListUseCase>();
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MainWindow>();
        }

        private void OnStartup(object sender, StartupEventArgs args)
        {
            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }
}
