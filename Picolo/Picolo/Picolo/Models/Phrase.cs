using System;
using System.Collections.Generic;
using System.Text;

namespace Picolo.Models
{
    public class Phrase
    {
        public string PText { get; set; }
        //public string PTitre { get; set; } Titre d'un question ? permet de personaliser
        public enum Type { Action, CS, Virus, Jeu }
        public Type type { get; set; }
       // public enum Participant { Un, Deux, Trois, Groupe}
        //public Participant participant { get; set; }
        public string participant { get; set; }

        public Phrase(String PText, String type, String participant)
        {
            PText = "$i dance ou boits 5 gorgés";
            type = ""+ Type.Action;
            participant = "Un";
        }
    }
}
