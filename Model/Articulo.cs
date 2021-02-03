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
        public int Cantidad { get; set; }
        public string ComboTipo { get; set; }
        /// <summary>
        /// Va con la opcion de CustomEsp
        /// </summary>
        public bool Validar { get; set; }
        /// <summary>
        /// Va con la opcion de Custom. Indica la cantidad de ingredientes incluidos en el Precio 
        /// </summary>
        public int IngredientesSinCosto { get; set; }
        /// <summary>
        /// Va con la opcion de Custom. Costo por Ingrediente Extra
        /// </summary>
        public decimal CostoIngredienteAdicional { get; set; }
        /// <summary>
        /// Va con la opcion de Custom. Indica si se despliega 0 Checks, 1 Check, 2 Checks. Esto en relacion a que un Ingrediente puede ser administrado a media Racion.
        /// </summary>
        public int Raciones_Checks { get; set; }
        // public string Grupo { get; set; }
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
