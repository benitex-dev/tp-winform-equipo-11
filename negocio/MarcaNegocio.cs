using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    internal class MarcaNegocio
    {

        public List<Marca> listar()
        {
            List<Marca> marcas = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.setConsulta("SELECT ID, Descripcion FROM MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca marca = new Marca();
                    marca.Id = (int)datos.Lector["ID"];
                    marca.Descripcion = (string)datos.Lector["DESCRIPCION"];

                    marcas.Add(marca);
    
                }  
                
                return marcas;
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
