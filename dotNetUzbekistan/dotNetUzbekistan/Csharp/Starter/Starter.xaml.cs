using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dotNetUzbekistan.Csharp.Starter
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Starter : ContentPage
    {
        public Starter()
        {
            InitializeComponent();
            var current = Connectivity.NetworkAccess;
            var profiles = Connectivity.ConnectionProfiles;
            if (current == NetworkAccess.Internet || profiles.Contains(ConnectionProfile.WiFi))
            {
                Title = "Starter";
                StackLayout stack = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal
                };
                WebView webView = new WebView
                {
                    Source = new UrlWebViewSource { Url = "https://docs.dot-net.uz/c-.net/basic/starter" },
                    VerticalOptions = LayoutOptions.FillAndExpand
                };

                this.Content = new StackLayout { Children = { stack, webView } };
            }

            else
            {
                Title = "Internetga ulanganligingizni tekshiring";
                Exit();
            }
            async void Exit()
            {
                await DisplayAlert(".NET Uzbekistan", "Dasturdan foydalanish uchun qurilmangizni internetga ulang!", "OK");
                //if (a == "Ok")
                await Navigation.PopAsync();
            }
        }
    }
}