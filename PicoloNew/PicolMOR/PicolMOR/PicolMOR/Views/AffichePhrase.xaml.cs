using PicolMOR.Models;
using Picolo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PicolMOR.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AffichePhrase : ContentPage
    {
        ObservableCollection<Phrase> phrases = new ObservableCollection<Phrase>();
        ObservableCollection<Player> players = new ObservableCollection<Player>();
        Phrase phraseSelect;
        Random random = new Random();
        public ListPhrases Liste = new ListPhrases();
        

        public AffichePhrase()
        {
            InitializeComponent();
            Liste.RemplireList();
            phrases = Liste.TabPhrases;
            players.Add(new Player { Name = "Matisse", gender = Player.Gender.Homme });
            players.Add(new Player { Name = "Gaby", gender = Player.Gender.Femme });
            players.Add(new Player { Name = "Alex", gender = Player.Gender.Autre });
            Console.WriteLine("=======================================================================");
            changeText();
        }

        Phrase setPhraseText()
        {
            if (phrases.Count != 0)
            {
                int position = random.Next(0, phrases.Count);
                phraseSelect = phrases[position];
                phrases.RemoveAt(position);
                Console.WriteLine(position);
                Console.WriteLine(phraseSelect.PText);
                return phraseSelect;
            }
            return null;
        }

        string RewrightPhrase(string p)
        {
            List<Player> tmp = players.ToList();
            if (p.Contains("$P1"))
            {
                Console.WriteLine("P1");
                int position = random.Next(0, tmp.Count);
                Console.WriteLine(position);
                string prenom = tmp[position].Name;
                Console.WriteLine(prenom);
                tmp.RemoveAt(position);
                p = p.Replace("$P1", prenom);
            }
            if (p.Contains("$P2"))
            {
                Console.WriteLine("P2");
                int position = random.Next(0, tmp.Count);
                string prenom = tmp[position].Name;
                tmp.RemoveAt(position);
                p = p.Replace("$P2", prenom);
            }
            if (p.Contains("$P3"))
            {
                Console.WriteLine("P3");
                int position = random.Next(0, tmp.Count);
                string prenom = tmp[position].Name;
                tmp.RemoveAt(position);
                p = p.Replace("$P3", prenom);
            }
            return p;
        }

        void changeText()
        {
            setPhraseText();
            champPhrase.Text = RewrightPhrase(phraseSelect.PText);

        }

        async void RefreshPhrase(object sender, EventArgs args)
        {
            changeText();
        }

    }
}