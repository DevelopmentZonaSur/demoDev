using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace test
{
    public partial class MainPage : ContentPage
    {
          
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

           
        }
        private async void ButtonWpp(object sender, EventArgs args)
        {
            await Task.Run(() => { Device.OpenUri(new Uri("https://wa.me/5491145281006")); });
        }
        private async void ButtonWeb(object sender, EventArgs args)
        {
            await Task.Run(() => { Device.OpenUri(new Uri("http://www.copello.com.ar/")); });
        }
        private async void ButtonExp(object sender, EventArgs args)
        {
            await Task.Run(() => { Device.OpenUri(new Uri("https://www.pagomiexpensa.com.ar/")); });
        }
        private async void ButtonCnRed(object sender, EventArgs args)
        {
            await Task.Run(() => { Device.OpenUri(new Uri("http://www.consorciosenred.com/cerDevelopment/cer_nav.nsf/inicio.html")); });
        }
        private async void ButtonFb(object sender, EventArgs args)
        {
            await Task.Run(() => { Device.OpenUri(new Uri("https://m.facebook.com/EstudioRjcopello/")); });
        }
        private async void ButtonFaq(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new FaqPage());
        }
        private async void ButtonAcercaDe(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new AcercaDePage());
        }
    }

}
    

