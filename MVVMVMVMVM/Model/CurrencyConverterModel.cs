using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMVMVMVM.Model
{
    public class CurrencyConverterModel
    {
        public double ConvertCurrency(double amount, double exchangeRate)
        {
            return amount * exchangeRate;
        }
    }
}
