using System;
using System.Collections.Generic;
using System.Text;

namespace Picolo.Models
{
    public class Phrase
    {
        public string PText { get; set; }
        public enum Type { Action, CS, Virus, Jeu }
        public Type type { get; set; }

        public int minPlayers { get; set; }
        public Phrase(String PText = "$i dance ou boits 5 gorgés", Type type = Type.Action, int minPlayer = 2)
        {
            this.PText = PText;
            this.type = type;
            this.minPlayers = minPlayer;
        }
    }
}
