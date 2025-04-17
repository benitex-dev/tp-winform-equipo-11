using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> articulos = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("SELECT ID,CODIGO,NOMBRE,DESCRIPCION,PRECIO FROM ARTICULOS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Id = (int)datos.Lector["ID"];
                    articulo.Descripcion = (string)datos.Lector["DESCRIPCION"];
                    articulo.CodArticulo = (string)datos.Lector["CODIGO"];
                    articulo.Nombre = (string)datos.Lector["NOMBRE"];
                    articulo.Precio = (decimal)datos.Lector["PRECIO"];
                    articulos.Add(articulo);
                }

                return articulos;
            }
            
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
