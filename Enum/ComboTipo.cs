using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBox.Enum
{
	public enum ComboTipo
	{
		Normal,
		Combo,
		Custom,
		CustomEst
	}
	/* 
	 * Comportamiento: 
	 *		Normal: Se manejan el nombre y precio de forma normal, sin mas detalle. ArticuloCantidad: 1
	 *		Combo:	Se manejan con un titulo y X cantidad de articulos fijos, pueden ser Intercambiables o No. ArticuloCantidad: Por definir.
	 *		Custom:	Se manejan con un titulo y X cantidad de articulos variables, no hay intercambiables, los articulos (Ingredientes) tendran costo extra.. ArticuloCantidad: 1
	 *		CustomEsp:	Se majean con un titulo y X cantidad de articulos variables, no hay intercambiables, los articulos (espesificaciones) no tiene costo extra.. ArticuloCantidad: 1
	 *		
	*/
}
