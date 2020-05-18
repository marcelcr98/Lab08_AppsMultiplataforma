using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab08
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InhetiranceCode : ContentPage
    {
        public InhetiranceCode()
        {
            InitializeComponent();
            var baseStyle = new Style(typeof(View))
            {
                Setters = {
                new Setter {
                    Property = View.HorizontalOptionsProperty, Value = LayoutOptions.Center    }
            }
            };

            var labelStyle = new Style(typeof(Label))
            {
                BasedOn = baseStyle,
                Setters = {
                new Setter { Property = Label.TextColorProperty, Value = Color.Teal    }
            }
            };

            var buttonStyle = new Style(typeof(Button))
            {
                BasedOn = baseStyle,
                Setters = {
                new Setter { Property = Button.BorderColorProperty, Value =    Color.Lime }
            }
            };

            Content = new StackLayout
            {
                Children = {
                new Label { Text = "Este es un Label", Style = labelStyle },
                new Button { Text = "Esto es un Button", Style = buttonStyle }
            }
            };
        }

    }
}