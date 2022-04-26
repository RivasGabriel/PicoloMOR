using Picolo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PicolMOR.Models
{
    public class ListPlayer : ObservableCollection<Player>
    {
        

        public void PlayerList()
        {
            this.Add(new Player { Name = "Matisse", gender = Player.Gender.Homme });
            this.Add(new Player { Name = "Gaby", gender = Player.Gender.Autre });
            this.Add(new Player { Name = "Alex", gender = Player.Gender.Homme });
            this.Add(new Player { Name = "Keira", gender = Player.Gender.Femme });
            this.Add(new Player { Name = "Vincent", gender = Player.Gender.Homme });
            this.Add(new Player { Name = "Kevin", gender = Player.Gender.Homme });
        }

       
    }
}
