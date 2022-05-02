using Picolo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Essentials;

namespace PicolMOR.Models
{
    public class ListPlayer : ObservableCollection<Player>
    {
        public string Username { get; set; }

       
    }
}
