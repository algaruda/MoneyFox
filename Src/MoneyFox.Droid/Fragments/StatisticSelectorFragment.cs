using Android.OS;
using Android.Runtime;
using Android.Views;
using MoneyFox.Business.ViewModels;
using MoneyFox.Business.ViewModels.Statistic;
using MoneyFox.Business.Views;
using MoneyFox.Foundation.Resources;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Views.Attributes;
using Xamarin.Forms.Platform.Android;

namespace MoneyFox.Droid.Fragments
{
    [MvxFragmentPresentation(typeof(MainViewModel), Resource.Id.content_frame)]
    [Register("moneyfox.droid.fragments.StatisticSelectorFragment")]
    public class StatisticSelectorFragment : MvxFragment<StatisticSelectorViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);
            Activity.Title = Strings.StatisticTitle;

            var fragment = new StatisticSelectorPage {BindingContext = ViewModel}.CreateSupportFragment(Activity);
            FragmentManager.BeginTransaction()
                           .Replace(Resource.Id.content_frame, fragment)
                           .Commit();

            return view;
        }
    }
}