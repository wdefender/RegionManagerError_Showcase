using Prism.Ioc;
using RegionManagerError_Showcase.Desktop.ViewModels;
using RegionManagerError_Showcase.Desktop.Views;
using System.Windows;

namespace RegionManagerError_Showcase.Desktop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>("ViewA");
        }
    }
}
