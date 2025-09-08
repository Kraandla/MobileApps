using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciCalc.ViewModels
{
    [INotifyPropertyChanged]
    internal class CalculatorPageViewModel
    {
        [ObservableProperty]
        private string inputText = string.Empty;

        [ObservableProperty]
        private string calculatedResult = "0";

        private bool isSciOpWaiting = false;

        [RelayCommand]
        private void Reset()
        {
            calculatedResult = "0";
            inputText = string.Empty;
            isSciOpWaiting = false;
        }

        [RelayCommand]
        private void Calculate()
        {
            if (inputText.Length == 0)
            {
                return;
            }
            if (isSciOpWaiting)
            {
                inputText += ")";
                isSciOpWaiting = false;
            }
        }
    }
}
