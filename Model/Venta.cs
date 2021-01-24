using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBox.Model
{
    public class Venta
    {
        public int VentaId { get; set; }
        public DateTime FechaHora { get; set; }
        public string Cajero { get; set; }
        public string Recibo { get; set; }
        public int CantidadArticulos { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Impuestos { get; set; }
        public decimal Total { get; set; }
        public int EnCorte { get; set; }
        public bool Cancelado { get; set; }

        public List<VentaDT> Productos { get; set; }
    }
}
