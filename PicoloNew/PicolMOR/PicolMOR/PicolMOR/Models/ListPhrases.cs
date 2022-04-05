using Picolo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            tabPhrases.Add(new Phrase { PText = "$P1 donne a $P2 une A ou boits 4 gorgées", type = Phrase.Type.Action });
            tabPhrases.Add(new Phrase { PText = "$P1 donne a $P2 et $P3 une B ou boits 1 gorgées", type = Phrase.Type.Action });
            tabPhrases.Add(new Phrase { PText = "$P1 donne a $P2 une C ou boits 1 gorgées", type = Phrase.Type.Action });
            tabPhrases.Add(new Phrase { PText = "$P1 donne a $P2 ou $P3 une D ou boits 1 gorgées", type = Phrase.Type.Action });
            tabPhrases.Add(new Phrase { PText = "$P1 donne a $P2 une E ou boits 1 gorgées", type = Phrase.Type.Action });
            tabPhrases.Add(new Phrase { PText = "$P1 donne a $P2 une F ou boits 1 gorgées", type = Phrase.Type.Action });
        }
    }
}
