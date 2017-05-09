using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigateScreens
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        async void OnNextScreen(object sender, EventArgs e)
        {
            App.MessageToPass = "Hello from Main Screen!";

            await Navigation.PushAsync(new SecondPage()); 

        }
    }
}
