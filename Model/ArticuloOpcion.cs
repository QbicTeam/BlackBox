using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using System.ComponentModel.DataAnnotations.Schema;

namespace BlackBox.Model
{
    public class ArticuloOpcion
    {
        public int Id { get; set; }
        /// <summary>
        /// Opcion Principal (Padre)
        /// </summary>
        public Articulo Articulo { get; set; }
        public int ArticuloId { get; set; }
        /// <summary>
        /// SubMenu o Parte (Opciones)
        /// </summary>
        public Articulo ArticuloOp { get; set; }
        public int ArticuloOpId { get; set; }

        public bool Intercambiable { get; set; }
        public bool Default { get; set; }
        public decimal Costo { get; set; }
        public List<ArticuloOpcion> Opciones { get; set; }
        /// <summary>
        /// Posicion asignada al momento del despliegue. (no asignable en BD).
        /// </summary>
        //[NotMapped]
        public int LocationY { get; set; }
    }
}
