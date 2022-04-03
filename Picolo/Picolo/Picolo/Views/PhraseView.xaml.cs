using Picolo.Models;
using Picolo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Picolo.Views
{
    public partial class PhraseView : ContentPage
    {
        Phrase phrase = new Phrase();
        
        public PhraseView(Phrase phraseSelected)
        {
            InitializeComponent();
            BindingContext = new PhraseViewModel(phraseSelected);
            phrase = phraseSelected;
        }

        
    }
}