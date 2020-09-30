using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Android_YoutubeDownloader.Services;
using Android_YoutubeDownloader.Views;

namespace Android_YoutubeDownloader
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
