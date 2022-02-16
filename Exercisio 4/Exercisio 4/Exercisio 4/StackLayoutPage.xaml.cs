using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exercisio_4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StackLayoutPage : ContentPage
    {
        public StackLayoutPage()
        {
            InitializeComponent();

            //var layout = new StackLayout
            //{
            //    BackgroundColor= Color.GreenYellow, 
            //    Spacing=20,
            //    Padding=new Thickness(0,20,0,0),
            //    Orientation=StackOrientation.Vertical
            //};

            //layout.Children.Add(new Label { Text = "Label 1", BackgroundColor = Color.Green });
            //layout.Children.Add(new Button { Text = "Button 1", BackgroundColor = Color.White });

            //Content = layout;

            //StackLayout stacklayout = new StackLayout
            //{
            //    BackgroundColor = Color.Red,
            //    Spacing = 20,
            //    Padding = new Thickness(0, 20, 0, 0),
            //    Orientation = StackOrientation.Vertical,
            //    VerticalOptions = LayoutOptions.Center,
            //    Children =
            //    {
            //        new Label
            //        {
            //            Text = "Xamarin Forms",
            //            BackgroundColor = Color.Blue,
            //            HorizontalOptions = LayoutOptions.Start
            //        },
            //        new Label
            //        {
            //            Text = "Sei lá",
            //            BackgroundColor = Color.Blue,
            //            HorizontalOptions = LayoutOptions.Center
            //        },
            //        new StackLayout
            //        {
            //            BackgroundColor = Color.Yellow,
            //            Spacing = 10,
            //            Padding = new Thickness(30),
            //            Orientation = StackOrientation.Horizontal,
            //            HorizontalOptions = LayoutOptions.Center,
            //            Children =
            //            {
            //                new Label
            //                {
            //                    Text = "Nagasaki",
            //                    BackgroundColor = Color.Aqua
            //                }
            //            }
            //        }
            //    },
            //};
            //Content = stacklayout; 
        }
    }
}