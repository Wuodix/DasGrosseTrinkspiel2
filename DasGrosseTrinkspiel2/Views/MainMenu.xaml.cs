﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DasGrosseTrinkspiel2.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void m_btnSpiele_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new GamesMenu();
        }

        private void m_btnRandom_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new RandomMenu();
        }

        private void m_btnSpieler_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new SpielerMenu();
        }
    }
}
