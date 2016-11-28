using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Default.Model.Menu
{
    public class MenuListView : ListView
    {
        /// <summary>
        /// Construtor da Classe.
        /// </summary>
        public MenuListView()
        {
            try
            {
                List<MenuItem> data = new MenuListData();

                this.ItemsSource = data;
                this.VerticalOptions = LayoutOptions.FillAndExpand;
                this.BackgroundColor = Color.Transparent;

                var cell = new DataTemplate(typeof(MenuCell));
                cell.SetBinding(MenuCell.TextProperty, "Titulo");

                this.ItemTemplate = cell;
            }
            catch(Exception ex)
            {
                App.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
        }        
    }
}
