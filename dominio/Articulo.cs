using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    internal class Articulo
    {
        public int Id { get; set; }
        public string CodArticulo { get; set; }
        public string Nombre { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public float Precio { get; set; }
        public Imagen Imagen { get; set; }
    }
}
