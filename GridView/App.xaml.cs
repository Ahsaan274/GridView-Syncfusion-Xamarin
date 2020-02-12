using Grid.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GridView
{
    public partial class App : Application
    {


        public App()

        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjA4NDM2QDMxMzcyZTM0MmUzMFprSG5sdEdvZjRQbUtONkVBK2pFZTJZaWpQZFZVMSs2Zjc2MitwdjE0REk9");
            InitializeComponent();
            MainPage = new NavigationPage(new LoginPage());
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
