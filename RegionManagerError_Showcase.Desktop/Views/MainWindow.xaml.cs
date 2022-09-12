using Prism.Regions;
using System.Windows;

namespace RegionManagerError_Showcase.Desktop.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IRegionManager regionManager)
        {
            InitializeComponent();
            DataContext = this;
            regionManager.RegisterViewWithRegion("TabRegion", "ViewA");
        }
    }
}