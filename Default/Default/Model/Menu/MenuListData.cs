using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Default.View;

namespace Default.Model.Menu
{
    public class MenuListData: List<MenuItem>
    {
        /// <summary>
        /// Construtor da classe.
        /// </summary>
        public MenuListData()
        {
            this.Add(new MenuItem()
            {
                Titulo = "Home",
                TargetType = typeof(Home)
            });

            this.Add(new MenuItem()
            {
                Titulo = "Login",
                TargetType = typeof(Login)
            });
        }
    }
}
