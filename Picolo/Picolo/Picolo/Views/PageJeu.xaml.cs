﻿using Picolo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Picolo.Views
{
    public partial class PageJeu : ContentPage
    {
        public PageJeu()
        {
            InitializeComponent();
            BindingContext = new RandomPhraseViewModel();
        }
    }
}