using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using MVVMVMVMVM.View;
using MVVMVMVMVM.Views;

namespace MVVMVMVMVM.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private double _amount;
        private double _exchangeRate;
        private double _result;
        private ICommand? _convertCommand;
        private ICommand _openCurrencySelectionCommand;

        public double Amount
        {
            get { return _amount; }
            set
            {
                _amount = value;
                OnPropertyChanged();
            }
        }

        public double ExchangeRate
        {
            get { return _exchangeRate; }
            set
            {
                _exchangeRate = value;
                OnPropertyChanged();
            }
        }

        public double Result
        {
            get { return _result; }
            set
            {
                _result = value;
                OnPropertyChanged();
            }
        }

        public ICommand ConvertCommand
        {
            get
            {
                if (_convertCommand == null)
                {
                    _convertCommand = new RelayCommand(Convert, CanConvert);
                }
                return _convertCommand;
            }
        }

        public ICommand OpenCurrencySelectionCommand
        {
            get
            {
                if (_openCurrencySelectionCommand == null)
                {
                    _openCurrencySelectionCommand = new RelayCommand(OpenCurrencySelection);
                }
                return _openCurrencySelectionCommand;
            }
        }

        private void Convert(object parameter)
        {
            Result = Amount * ExchangeRate;
        }

        private bool CanConvert(object parameter)
        {
 
            return true;
        }

        private void OpenCurrencySelection(object parameter)
        {
            CurrencySelectionWindow currencySelectionWindow = new CurrencySelectionWindow();
            currencySelectionWindow.Show();
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
