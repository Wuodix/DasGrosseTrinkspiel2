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

            Genders.Add("Männlich");
            Genders.Add("Weiblich");
            Genders.Add("Divers");
        }
    }
}
