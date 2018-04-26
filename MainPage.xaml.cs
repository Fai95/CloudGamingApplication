using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;

namespace CloudGamingApplication.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new CloudGamingApplication.App());

            AppCenter.Start("fa00bbae-478a-4bff-a76f-591159be33ac", typeof(Analytics));
        }
    }
}
