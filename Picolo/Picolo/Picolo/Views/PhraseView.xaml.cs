using Picolo.Models;
using Picolo.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Picolo.Views
{
    public partial class PhraseView : ContentPage
    {
        ObservableCollection<Phrase> phrases = new ObservableCollection<Phrase>();
        public PhraseView()
        {
            InitializeComponent();
            //BindingContext = new PhraseViewModel(phraseSelected);
            //phrase = phraseSelected;
            phrases.Add(new Phrase("$x donne a $y une fessé ou boits 4 gorgées", Phrase.Type.Action));
            phrases.Add(new Phrase("$x donne a $y une claque ou boits 1 gorgées", Phrase.Type.Action));
        }
        

    }
}