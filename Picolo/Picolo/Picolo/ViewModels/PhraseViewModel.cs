using Picolo.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using TD2.ViewModels;
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

        public PhraseViewModel(Phrase phrase)
        {
            P = phrase.PText;
            Type = phrase.type.ToString();
        }
        private ICommand _tapCommand;
 
        public ICommand TapCommand => _tapCommand ?? _tapCommand = new Command(OnTapped);

        void OnTapped()
        {
            // Do stuff
        }
    }
}
