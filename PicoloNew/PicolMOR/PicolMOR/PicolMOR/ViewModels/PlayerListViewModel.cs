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

namespace PicolMOR.ViewModels
{
    public class PlayerListViewModel: BaseViewModel
    {
        //ObservableCollection<Player> players = new ObservableCollection<Player>();
        ListPlayer players = new ListPlayer();
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
                                Players.TabPlayer.Remove(player);
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
        async void Show()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new ViewPlayerAdd(this)));
        }
        void Close()
        {
            Application.Current.MainPage.Navigation.PopModalAsync();
            player = null;
        }
        public void AddPlayer(Player player)
        {
            Players.TabPlayer.Add(player);
            this.Close();
        }

        public PlayerListViewModel()
        {
            
        }
    }
}

