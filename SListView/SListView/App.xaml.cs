using SListView.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SListView
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SimpleListView());
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
