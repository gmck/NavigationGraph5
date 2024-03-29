﻿using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;

namespace com.companyname.NavigationGraph5.Fragments
{
    public class SampleFragment2 : Fragment
    {
        public SampleFragment2() { }

        #region NewInstance
        internal static SampleFragment2 NewInstance()
        {
            SampleFragment2 fragment = new SampleFragment2();
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
            View view = inflater.Inflate(Resource.Layout.fragment_sample2, container, false);

            TextView textView = view.FindViewById<TextView>(Resource.Id.text_sample2);
            textView.Text = "This is Sample 2 fragment";
            return view;
        }
    }
}