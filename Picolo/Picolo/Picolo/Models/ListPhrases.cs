using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Picolo.Models
{
    public class ListPhrases
    {
        ObservableCollection<Phrase> phrases = new ObservableCollection<Phrase>();
        ObservableCollection<Phrase> phrasesInGame = new ObservableCollection<Phrase>();
        Phrase phraseSelected;
        Random random = new Random();

        public ObservableCollection<Phrase> Phrases
        {
            get { return phrases; }
            set  { phrases = value; }
        }
        public ObservableCollection<Phrase> PhrasesInGame
        {
            get { return phrasesInGame; }
            set { phrasesInGame = value; }
        }

        public ListPhrases()
        {
            /*string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "phrases.txt");
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
            Console.WriteLine(Phrases);*/
            /*Phrases.Add(new Phrase
            {
                PText = "$x donne a $y une fessé ou boits 4 gorgées",
                type = Phrase.Type.Action
            });
            Phrases.Add(new Phrase
            {
                PText = "$x donne a $y une claque ou boits 1 gorgées",
                type = Phrase.Type.Action
            });*/



            PhrasesInGame = Phrases;
            Console.WriteLine(PhrasesInGame);
        }

        public Phrase PhraseSelected
        {
            get { return phraseSelected; }
            set
            {
                int position = random.Next(0, PhrasesInGame.Count);
                phraseSelected = PhrasesInGame[position];
                PhrasesInGame.RemoveAt(position);
            }
        }
    }
}
