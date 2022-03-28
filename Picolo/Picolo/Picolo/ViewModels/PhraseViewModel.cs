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
        private string p;
        public string P { 
            get { return p; } 
            set { SetProperty(ref p, value); }
        }
        private string type;
        public string Type { 
            get { return type; } 
            set { SetProperty(ref type, value);} 
        }

        public PhraseViewModel(Phrase phrase)
        {
            P = phrase.P;
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
