using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace DasGrosseTrinkspiel2.ViewModels
{
    public class SpielerMenuViewModel
    {
        public ObservableCollection<Classes.Spieler> Gamers { get; }
        public ObservableCollection<string> Genders { get; set; }

        public SpielerMenuViewModel()
        {
            Gamers = new ObservableCollection<Classes.Spieler>();
            Genders = new ObservableCollection<string>();
            //Googeln was ObservableCollection ist
            Genders[0] = "Männlich";
            Genders[1] = "Weiblich";
        }
    }
}
