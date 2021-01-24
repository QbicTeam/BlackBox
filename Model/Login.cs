using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBox.Model
{
    public class Login
    {
        public string Version { get; set; }
        public string FechaVersion { get; set; }
        public string Sitio { get; set; }
        public string Computadora { get; set; }
        public decimal Taza { get; set; }
        public string Cajero { get; set; }
        public string Empresa { get; set; }
        public string RFC { get; set; }
        public string DireccionR1 { get; set; }
        public string DireccionR2 { get; set; }
        public string Caja { get; set; }
        public int NoRecibo { get; set; }
    }
}
