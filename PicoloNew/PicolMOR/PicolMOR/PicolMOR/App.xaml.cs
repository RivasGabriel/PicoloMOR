using PicolMOR.Models;
using PicolMOR.Views;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PicolMOR
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            //Preferences.Set("allname", "");

            //MainPage = new AffichePhrase();
            MainPage = new NavigationPage(new ViewPlayer());
        }

        protected override void OnStart()
        {
           
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
