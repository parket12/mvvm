using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVMVMVMVM.ViewModels
{
    public class CurrencySelectionViewModel : INotifyPropertyChanged
    {
        private List<CurrencyRate> _currencies;

        public List<CurrencyRate> Currencies
        {
            get { return _currencies; }
            set
            {
                _currencies = value;
                OnPropertyChanged();
            }
        }

        public CurrencySelectionViewModel()
        {

            Currencies = new List<CurrencyRate>
            {
                new CurrencyRate { Name = "USD", Rate = 72.50 },
                new CurrencyRate { Name = "CNY", Rate = 11.20 },
                new CurrencyRate { Name = "EUR", Rate = 85.70 }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class CurrencyRate
    {
        public string Name { get; set; }
        public double Rate { get; set; }
    }
}
