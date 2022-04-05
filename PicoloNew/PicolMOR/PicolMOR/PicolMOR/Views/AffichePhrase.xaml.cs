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
        List<Phrase> phrases = new List<Phrase>();
        ObservableCollection<Player> players = new ObservableCollection<Player>();
        Phrase phraseSelect;
        Random random = new Random();
        ListPhrases Liste = new ListPhrases();
        ListPlayer ListeJoueurs = new ListPlayer();
        int nbPhrases = 0;


        public AffichePhrase()
        {
            InitializeComponent();
            Liste.RemplireList();
            ListeJoueurs.RemplireList();
            phrases = Liste.TabPhrases.ToList();
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
            List<Player> tmp = ListeJoueurs.TabPlayer.ToList();
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
            if(nbPhrases == 20 || phrases.Count == 0)
            {
                champPhrase.Text = "Fin du jeu";
                BoutonRefresh.Text = "Rejouer";
                nbPhrases = 0;
                phrases = Liste.TabPhrases.ToList();
            }
            else
            {
                if (BoutonRefresh.Text == "Rejouer")
                {
                    BoutonRefresh.Text = "Refresh";
                }
                changeText();
                nbPhrases += 1;
            }

        }

    }
}