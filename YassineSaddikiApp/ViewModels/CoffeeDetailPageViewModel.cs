using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using YassineSaddikiApp.Models;




namespace YassineSaddikiApp.ViewModels
{
    public class CoffeeDetailPageViewModel : INotifyPropertyChanged
    {
        private CoffeeItems _coffee;

        public CoffeeItems Coffee
        {
            get { return _coffee; }
            set
            {
                if (_coffee != value)
                {
                    _coffee = value;
                    OnPropertyChanged(nameof(Coffee));
                }
            }
        }

        // Constructeur sans paramètres ajouté
        public CoffeeDetailPageViewModel()
        {
        }

        public CoffeeDetailPageViewModel(CoffeeItems coffee)
        {
            Coffee = coffee;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}


