using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default.Model.Menu
{
    /// <summary>
    /// Item do Menu.
    /// </summary>
    public class MenuItem
    {
        /// <summary>
        /// Titulo do elemento.
        /// </summary>
        public string Titulo { get; set; }

        /// <summary>
        /// "Tela" que será carregada.
        /// </summary>
        public Type TargetType { get; set; }
    }
}
