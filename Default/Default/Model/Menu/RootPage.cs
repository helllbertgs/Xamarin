using Default.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Default.Model.Menu
{
    public class RootPage : MasterDetailPage
    {
        MenuPage menuPage;

        /// <summary>
        /// Construtor da classe.
        /// </summary>
        public RootPage()
        {
            try
            {
                this.menuPage = new MenuPage();
                this.menuPage.Menu.ItemSelected += (sender, e) => NavigationTo(e.SelectedItem as MenuItem);

                this.Master = this.menuPage;
                this.Detail = new NavigationPage(new Home());
            }
            catch (Exception ex)
            {
                App.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
        }

        async void NavigationTo(MenuItem menu)
        {
            if (menu.Equals(null))
                return;
            
            try
            {
                Page displayPage = (Page)Activator.CreateInstance(menu.TargetType);
                this.Detail = new NavigationPage(displayPage);
            }
            catch(Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }

            this.menuPage.Menu.SelectedItem = null;
            this.IsPresented = false;
        }
    }
}
