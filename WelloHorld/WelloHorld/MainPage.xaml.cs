using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WelloHorld
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            await input.RelRotateTo(360, 1000);
            await DisplayAlert("Hey", input.Text + ", Wello Horld \U0001F60E", "Ok");
        }
    }
}
