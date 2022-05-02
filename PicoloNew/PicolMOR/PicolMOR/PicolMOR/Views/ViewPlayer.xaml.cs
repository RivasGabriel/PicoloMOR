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
using Picolo.Models;

namespace PicolMOR.Views
{

    public partial class ViewPlayer : ContentPage
    {
        
        PlayerListViewModel PLM = new PlayerListViewModel();

        public ViewPlayer()
        {
            InitializeComponent();
            BindingContext = new PlayerListViewModel();
        }

        public void Next(Object sender, EventArgs args)
        {

           Navigation.PushAsync(new AffichePhrase());
        }

        public void ShowTn(Object sender, EventArgs args)
        {
            tn.Text = Preferences.Get("allname", "");
            string all_name = tn.Text;
            Navigation.PushAsync(new AffichePhrase());
        }

        public void SupprName(Object sender, EventArgs args)
        {

            var button = sender as Button;
            Player player = button.BindingContext as Player;
            Preferences.Remove("name_"+player.Name);
            PLM.removePlayer(player);

        }
        
    }
}