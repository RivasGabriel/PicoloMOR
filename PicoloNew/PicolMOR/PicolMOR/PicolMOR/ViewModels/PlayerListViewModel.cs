using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using PicolMOR.ViewModel;
using Xamarin.Forms;
using Picolo.Models;
using PicolMOR.Views;
using PicolMOR.Models;
using Xamarin.Essentials;

namespace PicolMOR.ViewModels
{
    public class PlayerListViewModel: BaseViewModel
    {
        //ObservableCollection<Player> players = new ObservableCollection<Player>();

        public PlayerListViewModel vue;
        ListPlayer players ;
        public ListPlayer Players
        {
            get { return players; }
            set { SetProperty(ref players, value); }
        }

        Player player;
        public Player PlayerList
        {
            get { return player; }
            set
            {
                SetProperty(ref player, value);
                if (value != null)
                {
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        string choix = await Application.Current.MainPage.DisplayActionSheet($"Utilisateur{value.Name}", "Retour", "",  "Supprimer");
                        switch (choix)
                        {
                           
                            case "Supprimer":
                                Players.Remove(player);
                                break;
                            
                            default:
                                break;


                        }
                    });
                }
            }
        }

        public ICommand OnShowModalAddUserButtonClicked
        {
            get
            {
                return new Command(Show);
            }
        }
        public ICommand OnCancelButtonCLicked
        {
            get
            {
                return new Command(Close);
            }
        }
         void Show()
        {
             Application.Current.MainPage.Navigation.PushModalAsync(new ViewPlayerAdd(this));
        }
        void Close()
        {
            Application.Current.MainPage.Navigation.PopModalAsync();
            player = null;
        }
        public void AddPlayer(Player player)
        {
            Players.Add(player);
            this.Close();
        }

        public void removePlayer(Player player)
        {
            Players.Remove(player);
        }

        public PlayerListViewModel()
        {

            //foreach (string name in Preferences.Get("allname", "").Split(';'))
            //{
            //    Player p = new Player(name);
            //    Players.Add(p);
            //}

            players = App.players;
        }
    }
}

