using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBox.Model
{
    public class VentaDT
    {
        public int Id { get; set; }
        public int VentaId { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public int Nivel { get; set; }
        public string ProductoPadre { get; set; }
    }
}
