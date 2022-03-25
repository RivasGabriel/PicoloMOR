using Picolo.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Picolo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PageJeu());
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
