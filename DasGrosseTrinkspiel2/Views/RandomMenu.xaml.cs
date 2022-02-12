using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DasGrosseTrinkspiel2.Views
{
    public partial class RandomMenu : ContentPage
    {
        public RandomMenu()
        {
            InitializeComponent();
        }

        private void m_btnBack_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }
    }
}