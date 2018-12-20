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
        public Pantalla nuevaPantalla { get; set; }
        public MainPage()
        {
            nuevaPantalla = new Pantalla();
            nuevaPantalla.Width = (App.ScreenWidth)/2;
            nuevaPantalla.Height = (App.ScreenHeight)/3;             
            BindingContext = nuevaPantalla;
            InitializeComponent();

        }


    }
}
    

