using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Default.Model.Menu
{
    public class MenuPage : ContentPage
    {
        public MenuListView Menu { get; set; }

        public MenuPage()
        {

            try
            {
                this.Title = "Menu";
                this.BackgroundColor = Color.FromHex("33333");
                this.Menu = new MenuListView();

                var menuLabel = new ContentView
                {
                    Padding = new Thickness(10, 36, 0, 5),
                    Content = new Label()
                    {
                        TextColor = Color.FromHex("AAAAAA"),
                        Text = "MENU"
                    }
                };

                var layout = new StackLayout
                {
                    Spacing = 0,
                    VerticalOptions = LayoutOptions.FillAndExpand
                };

                layout.Children.Add(menuLabel);
                layout.Children.Add(this.Menu);

                Content = layout;   
            }
            catch (Exception ex)
            {
                App.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
