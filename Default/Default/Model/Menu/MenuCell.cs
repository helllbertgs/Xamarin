using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Default.Model.Menu
{
    /// <summary>
    /// Célula padrão.
    /// </summary>
    public class MenuCell : ImageCell
    {
        /// <summary>
        /// Construtor da classe.
        /// </summary>
        public MenuCell() : base()
        {
            try
            {
                this.TextColor = Color.FromHex("1D1831");
            }
            catch (Exception ex)
            {
                App.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
        }

        /// <summary>
        /// Construtor da classe.
        /// </summary>
        /// <param name="hexColor">Cor da célula. (Hexadecimal).</param>
        public MenuCell(string hex) : base()
        {
            try
            {
                this.TextColor = Color.FromHex(hex);       
            }
            catch (Exception ex)
            {
                App.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
