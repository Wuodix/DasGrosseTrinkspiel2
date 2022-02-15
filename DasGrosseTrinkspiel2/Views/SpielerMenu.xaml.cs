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
        ViewModels.SpielerMenuViewModel viewModel;
        public SpielerMenu()
        {
            InitializeComponent();
            
            BindingContext = viewModel = new ViewModels.SpielerMenuViewModel();
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

        private void m_btnAdd_Clicked(object sender, EventArgs e)
        {
            if(m_tbxName.Text != null && m_cmbxGender.SelectedItem != null)
            {
                Classes.Spieler spieler = new Classes.Spieler();
                spieler.Name = m_tbxName.Text;
                spieler.Geschlecht = m_cmbxGender.SelectedItem.ToString();

                viewModel.Gamers.Add(spieler);
            }
        }

        private void m_btnDelete_Clicked(object sender, EventArgs e)
        {
            Debug.WriteLine(sender.ToString());
            Debug.WriteLine("hi");
            m_lbxSpieler.FindByName(sender.ToString());
        }
    }
}