using PicolMOR.Models;
using PicolMOR.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PicolMOR
{
    public partial class App : Application
    {
        public static ListPlayer players = new ListPlayer();

        public static ListPlayer UpdateList()
        {
            ListPlayer _player = players;
            return _player;
        }

        public App()
        {
            InitializeComponent();

            //MainPage = new AffichePhrase();
            MainPage = new ViewPlayer();
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
