﻿using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;

namespace com.companyname.NavigationGraph5.Fragments
{
    public class SampleFragment3 : Fragment
    {
        public SampleFragment3() { }

        #region NewInstance
        internal static SampleFragment3 NewInstance()
        {
            SampleFragment3 fragment = new SampleFragment3();
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
            View view = inflater.Inflate(Resource.Layout.fragment_sample3, container, false);

            TextView textView = view.FindViewById<TextView>(Resource.Id.text_sample3);
            textView.Text = "This is Sample 3 fragment";
            return view;
        }
    }
}