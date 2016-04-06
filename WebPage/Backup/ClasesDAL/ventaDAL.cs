using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesDAL
{
    public class ventaDAL
    {
        //Declaración de variables
        string consultaSqlY = "";
        //Métodos implementados en la clase Venta
        #region VENTA
        public DataTable GetTodasVentas()
        {
            consultaSqlY = "select * " +
                           " from venta ";
            return Conexion.GetEjecutarSelect(consultaSqlY);
        }
        public DataTable GetCodigosVentas()
        {
            consultaSqlY = "select v.codigoventa" +
                           " from venta v";
            return Conexion.GetEjecutarSelect(consultaSqlY);
        }
        public DataTable GetVentasByCriterio(int id_ventaX, string codigoX, decimal montoX)
        {
            string byIdVentaX = "";
            string byMontoX = "";
            string byfechaX = "";

            if (id_ventaX != 0) byIdVentaX = " and v.id_venta = " + id_ventaX;
            if (montoX != 0) byMontoX = " and v.monto = '" + montoX + "'";

            consultaSqlY = "select v.id_venta, v.fecha, v.monto" +
                           " from venta v" +
                           " where v.id_venta > 0" + byIdVentaX + byMontoX + byfechaX;

            return Conexion.GetEjecutarSelect(consultaSqlY);
        }
        public int InsertarVenta(string codigoX, DateTime fechaX, decimal montoX,int id_personalX)
        {
            consultaSqlY = "INSERT INTO VENTA(codigoventa,fecha,monto,id_personal)" +
            " VALUES (@codigoventa,@fecha,@monto,@id_personal)";

            SqlParameter[] objParametros = new SqlParameter[4];
            objParametros[0] = new SqlParameter("@codigoventa", codigoX);
            objParametros[1] = new SqlParameter("@fecha", fechaX);
            objParametros[2] = new SqlParameter("@monto", montoX);
            objParametros[3] = new SqlParameter("@id_personal", id_personalX);

            Conexion.InsertarModificar(consultaSqlY, objParametros);
            int id_venta = Convert.ToInt16(GetVentasByCriterio(0, codigoX, montoX).Rows[0]["id_venta"]); ;
            return id_venta;
        }
        public void ModificarVenta(int id_ventaX, string codigoX, DateTime fechaX, decimal montoX,int id_personalX)
        {
            consultaSqlY = "update FACTURA set codigo=@codigo," +
            " fecha=@fecha,monto=@monto," +
            " id_personal=@id_personal " +
            " where id_venta=@id_venta";

            SqlParameter[] objParametros = new SqlParameter[6];
            objParametros[0] = new SqlParameter("@codigoventa", codigoX);
            objParametros[1] = new SqlParameter("@fecha", fechaX);
            objParametros[2] = new SqlParameter("@monto", montoX);
            objParametros[3] = new SqlParameter("@id_personal", id_personalX);
            objParametros[4] = new SqlParameter("@id_persona", id_ventaX);

            Conexion.InsertarModificar(consultaSqlY, objParametros);
        }
        #endregion
    }
}
