using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using LottoGenerator.Interface;
using LottoGenerator.FS;
using LottoGenerator.Droid.Implementation;

[assembly: Xamarin.Forms.Dependency(typeof(AndroidTruthSeeker))]
namespace LottoGenerator.Droid.Implementation
{
    public class AndroidTruthSeeker : ITruthSeeker
    {
        public bool IsWinningNumber()
        {
            var service = new TruthSeeker();
            return service.GetAndroidTruth();
        }
    }
}