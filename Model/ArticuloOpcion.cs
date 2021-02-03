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
        // public decimal Costo { get; set; } // El Costo esta puesto a nivel de articulo padre, y todos los ingredientes valen igual.
        /// <summary>
        /// Indica si se esta usando Media Racion. Se Manda 1 u 2 segun el tipo, esto se pone como sufijo, 0 cuando es completo (en este caso no se pone como sufijo)
        /// </summary>
        public int MediaRacion { get; set; }
        /// <summary>
        /// Debe Concatenar: MenuId: Nombre del Panel(Ej: Pan); Tamano (Num.Cols): "" Normal, 3, 4
        /// </summary>
        public string TipoOpciones { get; set; }
        public List<ArticuloOpcion> Opciones { get; set; }
        /// <summary>
        /// Posicion asignada al momento del despliegue. (no asignable en BD).
        /// </summary>
        //[NotMapped]
        public int LocationY { get; set; }
    }
}
