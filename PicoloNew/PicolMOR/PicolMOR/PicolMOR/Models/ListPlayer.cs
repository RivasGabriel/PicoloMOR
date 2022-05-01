using Picolo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Essentials;

namespace PicolMOR.Models
{
    public class ListPlayer : ObservableCollection<Player>
    {
        public string Username { get; set; }

        public void PlayerList()
        {
            Add(new Player { Name = "Matisse", gender = Player.Gender.Homme });
            Add(new Player { Name = "Gaby", gender = Player.Gender.Autre });
            Add(new Player { Name = "Alex", gender = Player.Gender.Homme });
            Add(new Player { Name = "Keira", gender = Player.Gender.Femme });
            Add(new Player { Name = "Vincent", gender = Player.Gender.Homme });
            Add(new Player { Name = "Kevin", gender = Player.Gender.Homme });
        }

       
    }
}
