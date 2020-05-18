using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab08
{

	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DynamicCode : ContentPage
    {
        bool originalStyle = true;
        public DynamicCode()
        {
            InitializeComponent();
            Resources["searchBarStyle"] = Resources["blueSearchBarStyle"];
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (originalStyle)
            {
                Resources["searchBarStyle"] = Resources["greenSearchBarStyle"];
                originalStyle = false;
            }
            else
            {
                Resources["searchBarStyle"] = Resources["blueSearchBarStyle"];
                originalStyle = true;
            }
        }
    }
}