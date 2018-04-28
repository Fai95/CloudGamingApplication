using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CloudGamingApplication.admin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ManageAccounts : ContentPage
	{
        string email;
        public ManageAccounts()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            InternetConnection connection = new InternetConnection();
            if (!connection.ConnectivityCheck())
            {
                Connectivity.Text = "الرجاء التحقق من الاتصال بشبكة الإنترنت";
                Connectivity.IsVisible = true;
            }

        }

        public ManageAccounts (string uname)
		{
			InitializeComponent ();

            NavigationPage.SetHasNavigationBar(this, false);

            InternetConnection connection = new InternetConnection();
            if (!connection.ConnectivityCheck())
            {
                Connectivity.Text = "الرجاء التحقق من الاتصال بشبكة الإنترنت";
                DisplayAlert("Cloud Gaming Application", Connectivity.Text, "موافق");
            }
            else
            {
                email = uname;
            }
        }

        private async void Parents_OnClicked(object sender, EventArgs e)
           => await Navigation.PushAsync(new ParentsLists(email));

        private async void SpeciaLists_OnClicked(object sender, EventArgs e)
            => await Navigation.PushAsync(new SpecLists(email));

        private async void Logout_OnClicked(object sender, EventArgs e)
            => await Navigation.PushAsync(new Roles());
    }
}