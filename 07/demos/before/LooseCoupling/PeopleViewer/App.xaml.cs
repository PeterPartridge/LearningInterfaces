using PeopleViewer.Presentation;
using PersonRepository.Caching;
using PersonRepository.CSV;
using PersonRepository.Service;
using System.Windows;

namespace PeopleViewer
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ServiceRepository wrappedRepository = new ServiceRepository();
            CachingRepository serviceRepository = new CachingRepository(wrappedRepository);
            PeopleViewModel peopleViewModel = new PeopleViewModel(serviceRepository);
            Application.Current.MainWindow = new MainWindow(peopleViewModel);

            Application.Current.MainWindow.Show();
        }
    }
}
