using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab08
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ExplicitDemo());

            };
            Item2.Clicked += async (sender, e) =>
            {

                await Navigation.PushAsync(new ExplicitCode());


            };
            Item3.Clicked += async (sender, e) =>
            {

                await Navigation.PushAsync(new ImplicitDemo());


            };

            Item4.Clicked += async (sender, e) =>
            {

                await Navigation.PushAsync(new ExplicitControlDemo());


            };

            Item5.Clicked += async (sender, e) =>
            {

                await Navigation.PushAsync(new ExplicitControlCode());


            };
        }
    }
}