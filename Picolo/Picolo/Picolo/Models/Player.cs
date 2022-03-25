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

        public Player() {
            Name = "Matisse";
            gender = Gender.Homme;
        }

    }
}
