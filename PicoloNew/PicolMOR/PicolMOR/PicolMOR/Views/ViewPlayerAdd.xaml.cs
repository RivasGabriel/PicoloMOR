using PicolMOR.Models;
using PicolMOR.ViewModels;
using Picolo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PicolMOR.Views
{
    public partial class ViewPlayerAdd : ContentPage
    {
        public PlayerListViewModel vue;
        public ViewPlayerAdd(PlayerListViewModel viewmodel)
        {
            InitializeComponent();
            vue = viewmodel;
            BindingContext = viewmodel;
        }

        public void CreatePlayer(Object sender, EventArgs args)
        {
            string playername = PlayerName.Text;

            Player player = new Player
            {
                Name = playername,
                gender = Player.Gender.Autre //par defaut

            };
            
            Preferences.Set("name_", player.Name) ; // le nom du joueur qu'on viens de rentrer

            Preferences.Set("allname", Preferences.Get("allname", "")+ player.Name); // tout le noms des joueurs rentrer stocker dans les préférence

            vue.AddPlayer(player);
        }
    }
}


        
    