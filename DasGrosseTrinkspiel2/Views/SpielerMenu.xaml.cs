using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;

namespace DasGrosseTrinkspiel2.Views
{
    public partial class SpielerMenu : ContentPage
    {
        public SpielerMenu()
        {
            InitializeComponent();
            
            BindingContext = new ViewModels.SpielerMenuViewModel();
        }

        private void OnSwiped(object sender, SwipedEventArgs e)
        {
            Debug.WriteLine("hi");
            switch (e.Direction)
            {
                case SwipeDirection.Right:
                    App.Current.MainPage = new MainMenu();
                    break;
            }
        }
    }
}