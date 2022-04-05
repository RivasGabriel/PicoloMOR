using System;
using System.Collections.Generic;
using System.Text;

namespace Picolo.Models
{
    public class Player
    {
        public string Name { get; set; }
        public enum Gender { Homme, Femme, Autre }
        public Gender gender { get; set;}

        public Player(string Name = "Matisse", Gender gender = Gender.Homme) {
            this.Name = Name;
            this.gender = gender;
        }

    }
}
