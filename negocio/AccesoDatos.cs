﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        
       public AccesoDatos ()
        {
            conexion = new SqlConnection ("server=.\\SQLEXPRESS; database=CATALOGO_DB_P3; integrated security=true");
            comando = new SqlCommand();
        }

        public void setConsulta(string consulta)
        {
            comando.CommandType=System.Data.CommandType.Text;   
            comando.CommandText = consulta; 
        }
        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {

                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
