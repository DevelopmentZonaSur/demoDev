using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace test
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);

		}
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await HomeScreen.ScaleTo(1, 2000);
            await ProgressBar.ProgressTo(1, 900, Easing.Linear);
            App.Current.MainPage = new NavigationPage(new MainPage());
        }
	}
}