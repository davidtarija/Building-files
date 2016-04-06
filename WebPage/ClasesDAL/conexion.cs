using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace ClasesDAL
{
    public static class Conexion
    {
        public static string cadena = @"Data Source= david-PC\SQLSERVER; Initial Catalog=Venta de Repuestos; Integrated Security=True";
        //////Comandos SQL para ejecutar la seleccion de datos 
        public static DataTable GetEjecutarSelect(string consultaSqlX)
        {
            return SqlHelper.ExecuteDataset(cadena, CommandType.Text, consultaSqlX).Tables[0];
        }
        //////Comandos SQL para ejecutar la inserción de datos 
        public static void InsertarModificar(string consultaSqlX)
        {
            SqlHelper.ExecuteNonQuery(cadena, CommandType.Text, consultaSqlX);
        }
        //////Comandos SQL para ejecutar la modificación de datos 
        public static void InsertarModificar(string consultaSqlX, SqlParameter[] parametrosX)
        {
            SqlHelper.ExecuteNonQuery(cadena, CommandType.Text, consultaSqlX, parametrosX);
        }
        public static void Eliminar(string consultaSqlX)
        {
            SqlHelper.ExecuteNonQuery(cadena, CommandType.Text, consultaSqlX);
        }
    }
}
