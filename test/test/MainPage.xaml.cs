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
           
        }
        async void ButtonWpp(object sender, EventArgs args)
        {
            await Task.Run(() => { Device.OpenUri(new Uri("https://wa.me/5491145281006")); });
        }
        async void ButtonWeb(object sender, EventArgs args)
        {
            await Task.Run(() => { Device.OpenUri(new Uri("http://www.copello.com.ar/")); });
        }
        async void ButtonExp(object sender, EventArgs args)
        {
            await Task.Run(() => { Device.OpenUri(new Uri("https://www.pagomiexpensa.com.ar/")); });
        }
        async void ButtonCnRed(object sender, EventArgs args)
        {
            await Task.Run(() => { Device.OpenUri(new Uri("http://www.consorciosenred.com/cerDevelopment/cer_nav.nsf/inicio.html")); });
        }
        async void ButtonFb(object sender, EventArgs args)
        {
            await Task.Run(() => { Device.OpenUri(new Uri("https://m.facebook.com/EstudioRjcopello/")); });
        }
    }

}
    

