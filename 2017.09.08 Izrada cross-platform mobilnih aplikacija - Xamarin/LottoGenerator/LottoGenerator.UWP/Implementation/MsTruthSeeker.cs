using LottoGenerator.Interface;
using LottoGenerator.FS;
using LottoGenerator.Droid.Implementation;

[assembly: Xamarin.Forms.Dependency(typeof(MsTruthSeeker))]
namespace LottoGenerator.Droid.Implementation
{
    public class MsTruthSeeker : ITruthSeeker
    {
        public bool IsWinningNumber()
        {
            var service = new TruthSeeker();
            return service.GetWindowsTruth();
        }
    }
}