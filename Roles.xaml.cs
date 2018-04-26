using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CloudGamingApplication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Roles : ContentPage
    {
        string role;
        public Roles()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
            InternetConnection connection = new InternetConnection();

            if (!connection.ConnectivityCheck())
            {
                Connectivity.Text = "الرجاء التحقق من الاتصال بشبكة الإنترنت";
                DisplayAlert("Cloud Gaming Application", Connectivity.Text, "موافق");
            }
        }


        private async void Parent_OnClick(object sender, EventArgs e)
        {
            role = "ولي أمر";
            await Navigation.PushAsync(new XML_S.MainPage(role));
        }

        private async void Specialist_OnClick(object sender, EventArgs e)
        {
            role = "أخصائي";
            await Navigation.PushAsync(new XML_S.MainPage(role));
        }

        private async void Admin_OnClick(object sender, EventArgs e)
        {
            role = "مشرف";
            await Navigation.PushAsync(new XML_S.MainPage(role));
        }
    }
}