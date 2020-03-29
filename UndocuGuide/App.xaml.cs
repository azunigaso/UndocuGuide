using System;
using UndocuGuide.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UndocuGuide
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new OnboardingPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
