using Picolo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using TD2.ViewModels;

namespace Picolo.ViewModels
{
    public class RandomPhraseViewModel : BaseViewModel
    {
        ObservableCollection<Phrase> phrases = new ObservableCollection<Phrase>();
        Phrase phraseSelected;
        Random random = new Random();

        public ObservableCollection<Phrase> Phrases {
            get { return phrases; }
            set { SetProperty(ref phrases, value); }
        }

        public RandomPhraseViewModel()
        {
            
            Phrases.Add(new Phrase
            {
                P = "$x donne a $y une fessé ou boits 4 gorgées",
                type = Phrase.Type.Action
            });
            Phrases.Add(new Phrase
            {
                P = "$x donne a $y une claque ou boits 1 gorgées",
                type = Phrase.Type.Action
            });
            Console.WriteLine(Phrases);
        }
        public Phrase PhraseSelected
        {
            get { return phraseSelected; }
            set 
            {
                int position = random.Next(0, phrases.Count);
                SetProperty(ref phraseSelected, Phrases[position]);
            }
        }
    }
}
