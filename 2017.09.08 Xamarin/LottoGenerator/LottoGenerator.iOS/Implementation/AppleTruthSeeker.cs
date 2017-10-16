using LottoGenerator.Interface;
using LottoGenerator.FS;
using LottoGenerator.Droid.Implementation;

[assembly: Xamarin.Forms.Dependency(typeof(AppleTruthSeeker))]
namespace LottoGenerator.Droid.Implementation
{
    public class AppleTruthSeeker : ITruthSeeker
    {
        public bool IsWinningNumber()
        {
            var service = new TruthSeeker();
            return service.GetIOsTruth();
        }
    }
}