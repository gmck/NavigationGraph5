﻿using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using AndroidX.Navigation;

namespace com.companyname.NavigationGraph5.Fragments
{
    public class LeaderboardFragment : Fragment
    {
        private NavFragmentOnBackPressedCallback onBackPressedCallback;

        public LeaderboardFragment() { }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            HasOptionsMenu = true;
            View view = inflater.Inflate(Resource.Layout.fragment_leaderboard, container, false);
            TextView textView = view.FindViewById<TextView>(Resource.Id.text_leaderboard);
            textView.Text = "This is Leaderboard fragment";
            return view;
        }

        public override void OnCreateOptionsMenu(IMenu menu, MenuInflater inflater)
        {
            // Don't want a menu
            base.OnCreateOptionsMenu(menu, inflater);
            menu.Clear();
        }

        #region OnResume
        public override void OnResume()
        {
            base.OnResume();

            onBackPressedCallback = new NavFragmentOnBackPressedCallback(this, true);
            //// Android docs:  Strongly recommended to use the ViewLifecycleOwner.This ensures that the OnBackPressedCallback is only added when the LifecycleOwner is Lifecycle.State.STARTED.
            //// The activity also removes registered callbacks when their associated LifecycleOwner is destroyed, which prevents memory leaks and makes it suitable for use in fragments or other lifecycle owners
            //// that have a shorter lifetime than the activity.
            //// Note: this rule out using OnAttach(Context context) as the view hasn't been created yet.
            RequireActivity().OnBackPressedDispatcher.AddCallback(ViewLifecycleOwner, onBackPressedCallback);
        }
        #endregion

        #region OnDestroy
        public override void OnDestroy()
        {
            onBackPressedCallback?.Remove();
            base.OnDestroy();
        }
        #endregion

        #region HandleBackPressed
        public void HandleBackPressed(NavOptions navOptions)
        {
            onBackPressedCallback.Enabled = false;

            NavController navController = Navigation.FindNavController(Activity, Resource.Id.nav_host);
            
            // Navigate back to the SlideShowFragment
            navController.PopBackStack(Resource.Id.slideshow_fragment, false);
            navController.Navigate(Resource.Id.slideshow_fragment, null, navOptions);
        }
        #endregion
    }
}