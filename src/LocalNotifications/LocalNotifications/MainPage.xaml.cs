using System;
using Xamarin.Forms;
using Plugin.LocalNotifications;

namespace LocalNotifications
{
    public partial class MainPage : ContentPage
    {
        private const int SecondsToNotify = 5;
        public MainPage()
        {
            InitializeComponent();
            btnNotification.Clicked += BtnNotification_Clicked;
        }

        void BtnNotification_Clicked(object sender, EventArgs e)
        {
            CrossLocalNotifications.Current.Show("Xamarin Latino", "Hello, this is a local notification from Xamarin Forms", 0, DateTime.Now.AddSeconds(SecondsToNotify));
        }
    }
}
