﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBox.Model
{
    public class Comanda
    {
        public Comanda()
        {
            Articulos = new List<Articulo>();
        }

        public List<Articulo> Articulos { get; set; }

        public decimal SubTotal { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaHora { get; set; }
        public string Cajero { get; set; }
    }
}
