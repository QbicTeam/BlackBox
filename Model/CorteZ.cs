using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBox.Model
{
    public class CorteZ
    {
        public string Sucursal { get; set; }
        public string CodSucursal { get; set; }
        public DateTime Fecha { get; set; }
        public string Supervisor { get; set; }
        public decimal VentaTotal { get; set; }
        public List<ProductoZ> Productos { get; set; }
    }
}
