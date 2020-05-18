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
            Item11.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new InhetiranceCode());
            };
            Item12.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new DynamicDemo());
            };
            Item13.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new DynamicCode());
            };
            Item14.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ClassDemo());
            };
            Item15.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new CssExample());
            };
        }
    }
}
