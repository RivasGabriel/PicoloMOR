using System;
using System.Collections.Generic;
using System.Text;

namespace Picolo.Models
{
    public class Phrase
    {
        public string P { get; set; }
        public enum Type { Action, CS, Virus, Jeu }
        public Type type { get; set; }

        public Phrase()
        {
            P = "$i dance ou boits 5 gorgés";
            type = Type.Action;
        }
    }
}
