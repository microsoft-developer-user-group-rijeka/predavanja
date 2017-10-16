using LottoGenerator.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace LottoGenerator
{
    public partial class App : Application
    {
        private static ViewModelLocator _locator;

        public App()
        {
            InitializeComponent();

            MainPage = new LottoGenerator.View.EntryPage();
        }

        public static ViewModelLocator Locator
        {
            get
            {
                return _locator ?? (_locator = new ViewModelLocator());
            }
        }


        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
