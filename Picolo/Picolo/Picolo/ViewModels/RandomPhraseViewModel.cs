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
            string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "phrases.txt");
            if (File.Exists(fileName))
            {
                string text = File.ReadAllText(fileName);
                string[] lines = text.Split('\n');
                foreach (var line in lines) {
                    string[] s = line.Split(';');
                    Phrases.Add(new Phrase
                    {
                        P = s[0],
                        type = (Phrase.Type) Enum.Parse(typeof(Phrase.Type), s[1])
                    });
                }
            }
            Console.WriteLine("=========="+fileName+"============");
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
