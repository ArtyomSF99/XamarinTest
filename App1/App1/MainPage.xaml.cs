using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : FlyoutPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        public void HandleMenuButtonClicked(object sender, EventArgs e)
        {
            if (Application.Current.MainPage is FlyoutPage flyoutPage)
            {
                flyoutPage.IsPresented = !flyoutPage.IsPresented;
            }
        }

        private void Page1_Clicked(object sender, EventArgs e)
        {
            Detail = new ContentPage
            {
                Content = new StackLayout
                {
                    Children = {
                        new Button { Text = "Open sidebar",
                                    Command = new Command(() => IsPresented = !IsPresented) },
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
                        new Button { Text = "Open sidebar",
                                    Command = new Command(() => IsPresented = !IsPresented) },
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
