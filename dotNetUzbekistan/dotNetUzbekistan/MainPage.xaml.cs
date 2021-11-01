using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace dotNetUzbekistan
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var current = Connectivity.NetworkAccess;
            var profiles = Connectivity.ConnectionProfiles;
            if (current != NetworkAccess.Internet || !profiles.Contains(ConnectionProfile.WiFi))
            {
                DisplayAlert(".NET Uzbekistan", "Dasturdan to'liq foydalanish uchun internetga ulanishni maslahat beramiz", "OK");
            }
        }
        public async void dotnetButton(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new dotNetUzbekistan.dotNet.dotNet());
        }
        public async void csharpButton(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new dotNetUzbekistan.Csharp.Csharp());
        }
        private async void LoyihalarOnClick(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new dotNetUzbekistan.Loyihalar.Loyihalar());
        }
    }
}
