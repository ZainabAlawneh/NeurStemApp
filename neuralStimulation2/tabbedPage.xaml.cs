using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace neuralStimulation2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class tabbedPage : Xamarin.Forms.TabbedPage
    {
        public tabbedPage()
        {
            InitializeComponent();
            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            

        }

        private void TabbedPage_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}