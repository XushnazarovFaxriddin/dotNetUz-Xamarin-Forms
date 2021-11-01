using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dotNetUzbekistan.dotNet
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class dotNet : ContentPage
    {

        public dotNet()
        {

            var current = Connectivity.NetworkAccess;
            var profiles = Connectivity.ConnectionProfiles;
            if (current == NetworkAccess.Internet || profiles.Contains(ConnectionProfile.WiFi))
            {
                Title = ".NET Uzbekistan";
                StackLayout stack = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal
                };
                WebView webView = new WebView
                {
                    Source = new UrlWebViewSource { Url = "https://docs.dot-net.uz/c-.net/" },
                    VerticalOptions = LayoutOptions.FillAndExpand
                };

                this.Content = new StackLayout { Children = { stack, webView } };
            }        

            else {
                Title = "Internetga ulanganligingizni tekshiring";
                Exit();
            }
            async void Exit()
            {
                var a = await DisplayActionSheet("Dasturdan foydalanish uchun qurilmangizni internetga ulang!", "Ok", null, ".NET Uzbekistan Community");

                //if (a == "Ok")
                    await Navigation.PopAsync();
            }
        }

    }
}
