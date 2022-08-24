using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;

namespace com.companyname.NavigationGraph5.Fragments
{
    public class SampleFragment1 : Fragment
    {
        public SampleFragment1() { }

        #region NewInstance
        internal static SampleFragment1 NewInstance()
        {
            SampleFragment1 fragment = new SampleFragment1();
            return fragment;
        }
        #endregion
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            View view = inflater.Inflate(Resource.Layout.fragment_sample1, container, false);

            TextView textView = view.FindViewById<TextView>(Resource.Id.text_sample1);
            textView.Text = "This is Sample 1 fragment";
            return view;
        }
    }
}