using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoGenerator.ViewModel
{
    public class NumberGeneratorViewModel : ViewModelBase
    {
        private ObservableCollection<int> _winningNumbers;
        private RelayCommand _generateCommand;

        public NumberGeneratorViewModel()
        {
            GenerateWinningNumbersCommand = new RelayCommand(GenerateWinningNumbersFunction);
            WinningNumbers = new ObservableCollection<int>();
        }

        private void GenerateWinningNumbersFunction()
        {
            var random = new Random();
            var possibleNumbers = Enumerable.Range(1, 47);
            var winningNumbers = possibleNumbers.OrderBy(number => random.Next()).Take(6);
            WinningNumbers.Clear();
            foreach (var number in winningNumbers)
            {
                WinningNumbers.Add(number);
            }
        }

        public ObservableCollection<int> WinningNumbers
        {
            get { return _winningNumbers; }
            set
            {
                _winningNumbers = value;
                RaisePropertyChanged(() => WinningNumbers);
            }
        }

        public RelayCommand GenerateWinningNumbersCommand
        {
            get { return _generateCommand; }
            set
            {
                _generateCommand = value;
                RaisePropertyChanged(() => GenerateWinningNumbersCommand);
            }
        }
    }
}
