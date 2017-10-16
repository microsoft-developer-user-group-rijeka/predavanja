using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace LottoGenerator.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private string _mvvmString;

        public MainViewModel()
        {
            MvvmString = "Hello from Mvvm in Xamarin.Forms";
            PressButtonCommand = new RelayCommand(PressButtonFunction);
        }

        private void PressButtonFunction()
        {
            MvvmString = "Button PRESSED!";
        }

        public string MvvmString
        {
            get { return _mvvmString; }
            set
            {
                _mvvmString = value;
                RaisePropertyChanged(() => MvvmString);
            }
        }

        public RelayCommand PressButtonCommand { get; set; }
    }
}