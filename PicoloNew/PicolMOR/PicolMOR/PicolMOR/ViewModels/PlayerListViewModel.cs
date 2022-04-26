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

namespace PicolMOR.ViewModels
{
    public class PlayerListViewModel: BaseViewModel
    {
        ObservableCollection<Player> players = new ObservableCollection<Player>();
        public ObservableCollection<Player> Players
        {
            get { return players; }
            set { SetProperty(ref players, value); }
        }

        ObservableCollection<Player> genderplayers = new ObservableCollection<Player>();
        public ObservableCollection<Player> Genderplayers
        {
            get { return genderplayers; }
            set { SetProperty(ref genderplayers, value); }
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
                        string choix = await Application.Current.MainPage.DisplayActionSheet($"Utilisateur{value.Name}", "Retour", "", "Modifier", "Supprimer");
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

        //Player playergender;
        //public Player playergenderlist
        //{
        //    get { return playergender; }
        //    set
        //    {
        //        SetProperty(ref playergender, value);
        //        if(value != null)
        //        {
        //            Device.BeginInvokeOnMainThread(async () =>
        //            {
        //                string choix = await Application.Current.MainPage.DisplayActionSheet($"Utilisateur{value.gender}", "Retour", "", "Homme", "Femme" ,"Autre");
        //                switch(choix)
        //                {
        //                    case "Homme":
        //                        //PlayerGenre.Text = "Homme";
        //                        break;
        //                    case "Femme":
        //                        //PlayerGenre.Text = "Femme";
        //                        break;
        //                    case "Autre":
        //                        //PlayerGenre.Text = "Autre";
        //                        break;
        //                }
        //            });                       
                    
        //        }
        //    }
        //}

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
            Players.Add(player);
            this.Close();
        }

        public PlayerListViewModel()
        {
            Players.Add(new Player { Name = "TotoleZozo", gender = Player.Gender.Autre });
        }
    }
}

