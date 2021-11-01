using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dotNetUzbekistan.Csharp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Csharp : ContentPage
    {
        public Csharp()
        {
            InitializeComponent();
        }
        private async void StarterOnClick(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Starter.Starter());
        }
        private async void EssentialOnClick(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Essential.Essential());
        }
        private async void ProfessionalOnClick(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Professional.Professional());
        }
    }
}