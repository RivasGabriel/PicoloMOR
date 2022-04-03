using Picolo.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Picolo.ViewModels;
using Xamarin.Forms;

namespace Picolo.ViewModels
{
    public class PhraseViewModel : BaseViewModel
    {
        private string _phrasetext;
        public string P { 
            get { return _phrasetext; } 
            set { SetProperty(ref _phrasetext, value); }
        }

        private string _type;
        public string Type { 
            get { return _type; } 
            set { SetProperty(ref _type, value);} 
        }

        private string _participant;
        public string Participant
        {
            get { return _participant; }
            set { SetProperty(ref _participant, value); }
        }

        
        private ICommand _tapCommand;
 
        //public ICommand TapCommand => _tapCommand ?? _tapCommand = new Command(OnTapped);

        void OnTapped()
        {
            // Do stuff
        }

        public string PrenomRandom()
        {
            Random rd = new Random();
            int rand_num_prenom = rd.Next(0, System.Enum.GetNames(typeof(Player)).Length);
            string rand_prenom = "" + (Player)rand_num_prenom;
            Labelprenomtext.Text = rand_prenom + rand_num_prenom;
            return rand_prenom;
        }

        Phrase ReadFile()
        {
            //fonction de lecture du fichier contenant les phrases + selection aléatoire d'une phrase

            Phrase phraseTest = new Phrase("$P1 dance ou boits 5 gorgés", "Action", "Un");
            return phraseTest;
            
           
        }

        void RandomPhrase()
        {
            Phrase phrase = ReadFile();
            string prenom = PrenomRandom();
            switch (phrase.participant)
            {
                case "Un":
                    {
                        var change = phrase.PText.Replace("$P1", prenom);
                        break;
                    }
                case "Deux":
                    {
                        var change = phrase.PText.Replace("$P1", prenom);
                        string prenom_ = PrenomRandom();
                        while(prenom == prenom_)
                        {
                            prenom_ = PrenomRandom();
                        }
                        var changeb = change.Replace("$P2", prenom_);
                        break;
                    }
                case "Trois":
                    {
                        //meme principe 
                        break;
                    }
                case "Groupe":
                    {
                        //meme principe 
                        break;
                    }
            }
           

        }

        public PhraseViewModel(Phrase phrase)
        {
            

            P = phrase.PText;
            Type = phrase.type.ToString();
            Participant = phrase.participant.ToString();
        }
    }
}
