using PicolMOR.Views;
using Picolo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;

namespace PicolMOR.Models
{
    public class ListPhrases
    {
        ObservableCollection<Phrase> tabPhrases = new ObservableCollection<Phrase>();

        public ObservableCollection<Phrase> TabPhrases
        {
            get { return tabPhrases; }
            set { tabPhrases = value; }
        }

        public void RemplireList()
        {
            
            //tabPhrases.Add(new Phrase { PText = "$P1 donne a $P2 A ou boits 4 gorgées", type = Phrase.Type.Action, minPlayers = 2 });
            //tabPhrases.Add(new Phrase { PText = "$P1 donne a $P2 et $P3 B ou boits 1 gorgées", type = Phrase.Type.CS, minPlayers = 2});
            //tabPhrases.Add(new Phrase { PText = "$P1 donne a $P2 C ou boits 1 gorgées", type = Phrase.Type.Jeu, minPlayers = 3});
            //tabPhrases.Add(new Phrase { PText = "$P1 donne a $P2 ou $P3 D ou boits 1 gorgées", type = Phrase.Type.Action, minPlayers = 2});
            //tabPhrases.Add(new Phrase { PText = "$P1 donne a $P2 E ou boits 1 gorgées", type = Phrase.Type.CS, minPlayers = 2 });
            //tabPhrases.Add(new Phrase { PText = "$P1 fait F ou boits 1 gorgées", type = Phrase.Type.Virus, minPlayers = 1});
        }
    }
}
