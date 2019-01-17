using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace test
{

    public class SplashPage : ContentPage
    {
        Image splashImage;        
        ProgressBar progressBar;
       
        
        public SplashPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            var sub = new AbsoluteLayout();

            progressBar = new ProgressBar
            {
                
                Progress = 0,
                    ProgressColor = Color.Black,                
                                         
                
            };
          
            splashImage = new Image
            {
                Source = "whatsapplogo.png",
                WidthRequest = 100,
                HeightRequest = 100
            };
            
            AbsoluteLayout.SetLayoutFlags(splashImage, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            AbsoluteLayout.SetLayoutFlags(progressBar, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(progressBar, new Rectangle(0.4, 0.7, (App.ScreenWidth) - 50, App.ScreenHeight));
            
            sub.Children.Add(splashImage);
            sub.Children.Add(progressBar);
            this.BackgroundColor = Color.White;
            this.Content = sub;
            

        }
        
        
        protected override async void OnAppearing()
        {            
            base.OnAppearing();
            await splashImage.ScaleTo(1, 2000);
            
            await progressBar.ProgressTo(1, 900, Easing.Linear);

            Application.Current.MainPage = new NavigationPage(new MainPage());
        }

       
    }
}

