using PicolMOR.Models;
using PicolMOR.ViewModels;
using Picolo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PicolMOR.Views
{

    public partial class ViewPlayer : ContentPage
    {
        

        public ViewPlayer()
        {
            InitializeComponent();
            BindingContext = new PlayerListViewModel();
        }

        public void Next(Object sender, EventArgs args)
        {
            App.players = (ListPlayer)BindingContext;
        }

        public void ShowTn(Object sender, EventArgs args)
        {
            tn.Text = Preferences.Get("allname", "");
            string all_name = tn.Text;
        }
    }
}