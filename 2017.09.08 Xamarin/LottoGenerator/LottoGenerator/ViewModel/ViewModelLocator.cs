using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace LottoGenerator.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<NumberGeneratorViewModel>();
            SimpleIoc.Default.Register<TruthSeekerViewModel>();
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }


        public NumberGeneratorViewModel NumberGenerator
        {
            get
            {
                return ServiceLocator.Current.GetInstance<NumberGeneratorViewModel>();
            }
        }

        public TruthSeekerViewModel TruthSeeker
        {
            get
            {
                return ServiceLocator.Current.GetInstance<TruthSeekerViewModel>();
            }
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}