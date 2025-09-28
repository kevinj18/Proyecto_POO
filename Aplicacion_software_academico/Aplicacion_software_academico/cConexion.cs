using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Aplicacion_software_academico
{
    internal class cConexion
    {

        public SqlConnection Conexion = new SqlConnection(cadena);
        static private string cadena = @"Data Source=.\SQLEXPRESS;Initial Catalog=Software_Academico;Integrated Security=True;Encrypt=False; Connection Timeout=30";


        //public static SqlConnection ObtenerConexion()
        //{
        //    SqlConnection conexion = new SqlConnection(cadena);
        //    try
        //    {
        //        conexion.Open();
        //        Console.WriteLine("Conexión establecida con SQL Server");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error de conexión: " + ex.Message);
        //    }
        //    return conexion;
        //}

            public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }

    }
}
