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
        public void agregarArticulo(Articulo articulo)
        {   AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setConsulta("INSERT INTO ARTICULOS (Codigo,Nombre,Descripcion,Precio,IdCategoria,IdMarca)values('"+articulo.CodArticulo+"','"+articulo.Nombre+"','"+articulo.Descripcion+"',"+articulo.Precio+",@IdCategoria,@IdMarca)");
                accesoDatos.setParametro("@IdCategoria", articulo.Categoria.Id);
                accesoDatos.setParametro("@IdMarca", articulo.Marca.Id);
                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }

        public List<Articulo> listar()
        {
            List<Articulo> articulos = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("SELECT A.ID, CODIGO, NOMBRE, A.DESCRIPCION, PRECIO, M.Descripcion Marca, C.Descripcion Categoria FROM ARTICULOS A, MARCAS M, CATEGORIAS C WHERE M.ID = A.IDMARCA AND C.ID = A.IdCategoria");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Id = (int)datos.Lector["ID"];
                    articulo.Descripcion = (string)datos.Lector["DESCRIPCION"];
                    articulo.CodArticulo = (string)datos.Lector["CODIGO"];
                    articulo.Nombre = (string)datos.Lector["NOMBRE"];
                    articulo.Precio = (decimal)datos.Lector["PRECIO"];
                    
                    articulo.Marca = new Marca();
                    articulo.Marca.Descripcion = (string)datos.Lector["Marca"];
                    
                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    
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
