using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LottoGenerator.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TruthSeekingPage : ContentPage
    {
        public TruthSeekingPage()
        {
            InitializeComponent();

            BindingContext = App.Locator.TruthSeeker;
        }
    }
}