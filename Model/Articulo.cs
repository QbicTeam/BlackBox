using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using System.ComponentModel.DataAnnotations.Schema;

namespace BlackBox.Model
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Producto { get; set; }
        public decimal Precio { get; set; }
        public int Pendientes { get; set; }
        public string Tipo { get; set; }
        public string ComboTipo { get; set; }
        public string Grupo { get; set; }
        public List<ArticuloOpcion> Opciones { get; set; }
        /// <summary>
        /// Posicion asignada al momento del despliegue. (no asignable en BD).
        /// </summary>
        //[NotMapped]
        public int LocationY { get; set; }
    }
}
