﻿using Picolo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PicolMOR.Models
{
    public class ListPlayer
    {
        ObservableCollection<Player> tabPlayer = new ObservableCollection<Player>();

        public ObservableCollection<Player> TabPlayer
        {
            get { return tabPlayer; }
            set { tabPlayer = value; }
        }

        public void RemplireList()
        {
            TabPlayer.Add(new Player { Name = "Matisse", gender = Player.Gender.Homme });
            TabPlayer.Add(new Player { Name = "Gaby", gender = Player.Gender.Autre });
            TabPlayer.Add(new Player { Name = "Alex", gender = Player.Gender.Homme });
            TabPlayer.Add(new Player { Name = "Keira", gender = Player.Gender.Femme });
            TabPlayer.Add(new Player { Name = "Veincent", gender = Player.Gender.Homme });
            TabPlayer.Add(new Player { Name = "Kevin", gender = Player.Gender.Homme });
        }
    }
}
