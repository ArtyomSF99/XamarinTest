using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyFlyoutPage : FlyoutPage
    {
        public MyFlyoutPage()
        {
            InitializeComponent();
        }

        private void Page1_Clicked(object sender, EventArgs e)
        {
            Detail = new ContentPage
            {
                Content = new StackLayout
                {
                    Children = {
                        new Label { Text = "Page 1",
                                    HorizontalOptions = LayoutOptions.Center,
                                    VerticalOptions = LayoutOptions.CenterAndExpand }
                    }
                }
            };
            IsPresented = false;
        }


        private void Page2_Clicked(object sender, EventArgs e)
        {
            Detail = new ContentPage
            {
                Content = new StackLayout
                {
                    Children = {
                        new Label { Text = "Page 2",
                                    HorizontalOptions = LayoutOptions.Center,
                                    VerticalOptions = LayoutOptions.CenterAndExpand }
                    }
                }
            };
            IsPresented = false;
        }
    }
}