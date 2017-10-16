namespace LottoGenerator.ViewModel
{
    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.Command;
    using LottoGenerator.Interface;
    using Xamarin.Forms;

    public class TruthSeekerViewModel : ViewModelBase
    {
        public TruthSeekerViewModel()
        {
            ForecastCommand = new RelayCommand(ForecastFunction);
        }

        private void ForecastFunction()
        {
            if (DependencyService.Get<ITruthSeeker>().IsWinningNumber())
            {
                Forecast = "DING DING DING!!!";
            }
            else
            {
                Forecast = "You shall not bet on this, dude!";
            }
        }

        private string _forecast;

        public string Forecast
        {
            get { return _forecast; }
            set
            {
                _forecast = value;
                RaisePropertyChanged(() => Forecast);
            }
        }

        public RelayCommand ForecastCommand { get; set; }
    }
}
