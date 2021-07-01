using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeekHub_WS.Models
{
    public class ItProducto
    {
        public string NProducto { get; set; }
        public int ProductoId { get; set; }
        public decimal Price { get; set; }
        public int CategoriaId { get; set; }
        public string NCategoria { get; set; }
        public string URL_Image { get; set; }
        public DateTime? FRegistro{ get; set; }
    }
}