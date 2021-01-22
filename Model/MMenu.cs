using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBox.Model
{
    public class MMenu
    {
        public List<Articulo> HNR { get; set; }
        public List<Articulo> Pizza { get; set; }
        public List<Articulo> Pan { get; set; }
        public List<Articulo> Bebidas { get; set; }
        public List<Articulo> Alas { get; set; }
        public List<Articulo> Complementos { get; set; }
        public List<Articulo> NoComida { get; set; }
        public List<Articulo> OtrasComidas { get; set; }
        public List<Articulo> Uber { get; set; }
        public List<Articulo> Especiales { get; set; }
        public List<Articulo> EnEspera { get; set; }
        public List<Articulo> Rappi { get; set; }
        
    }
}
