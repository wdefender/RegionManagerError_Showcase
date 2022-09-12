using Prism.Regions;
using System.Windows.Automation;
using System.Windows.Controls;

namespace RegionManagerError_Showcase.Desktop.Views
{
    /// <summary>
    /// Interaction logic for ViewA
    /// </summary>
    [ViewSortHint("100")]
    public partial class ViewA : UserControl
    {
        public ViewA()
        {
            InitializeComponent();
            AutomationProperties.SetName(tb, "MyControlName");
        }
    }
}
