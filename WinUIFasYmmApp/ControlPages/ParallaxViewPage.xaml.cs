using WinUIFasYmmApp.Data;
using System.Linq;
using Microsoft.UI.Xaml.Navigation;

namespace WinUIFasYmmApp.ControlPages
{
    public sealed partial class ParallaxViewPage : ItemsPageBase
    {
        public ParallaxViewPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            Items = ControlInfoDataSource.Instance.Groups.SelectMany(g => g.Items).OrderBy(i => i.Title).ToList();
        }
    }
}
