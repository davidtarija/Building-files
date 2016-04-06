using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesDAL
{
    public class DetalleVentaDAL
    {
        //Declaración de variables
        string consultaSqlY = "";
        //Métodos implementados en la clase para insertar, modificar, seleccionar
        #region DETALLE_VENTA
        public DataTable GetTodosDetalleVentas()
        {
            consultaSqlY = "select dv.*, v.id_detalleventa" +
                           " from detalleventa dv";
            return Conexion.GetEjecutarSelect(consultaSqlY);
        }
        public DataTable GetDetalleVentasByCriterio(int id_ventaX)
        {
            string byIdVentaX = "";

            if (id_ventaX != 0) byIdVentaX = " and dv.id_venta = " + id_ventaX;

            consultaSqlY = "select *" +
                           " from detalleventa dv" +
                           " where v.id_detalleventa > 0" + byIdVentaX;

            return Conexion.GetEjecutarSelect(consultaSqlY);
        }
        public DataTable GetDetalleVentasByCodigo(string codigoventaX)
        {
            consultaSqlY = "select dv.id_repuesto,r.descripcion,dv.codigoventa,dv.cantidad,dv.subtotal,v.monto" +
                           " from detalleventa dv, repuesto r,venta v" +
                           " where dv.id_repuesto = r.id_repuesto and v.id_venta = dv.id_venta and dv.codigoventa = '" + codigoventaX + "'";

            return Conexion.GetEjecutarSelect(consultaSqlY);
        }

        public void InsertarDetalleVenta(int id_ventaX, int id_repuestoX, decimal subtotalX, int cantidadX, string codigoventaX)
        {
            consultaSqlY = "INSERT INTO DETALLEVENTA(id_venta,id_repuesto,subtotal,cantidad,codigoventa)" +
            " VALUES (@id_venta,@id_repuesto,@subtotal,@cantidad,@codigoventa)";

            SqlParameter[] objParametros = new SqlParameter[5];
            objParametros[0] = new SqlParameter("@id_venta", id_ventaX);
            objParametros[1] = new SqlParameter("@id_repuesto", id_repuestoX);
            objParametros[2] = new SqlParameter("@subtotal", subtotalX);
            objParametros[3] = new SqlParameter("@cantidad", cantidadX);
            objParametros[4] = new SqlParameter("@codigoventa", codigoventaX);
            Conexion.InsertarModificar(consultaSqlY, objParametros);
        }
        public void ModificarDetalleVenta(int id_detalleventaX, int id_ventaX, int id_repuestoX, decimal subtotalX, int cantidadX, string codigoventaX)
        {
            consultaSqlY = "update DETALLEVENTA set id_venta=@id_venta,id_repuesto=@id_repuesto, " +
            " subtotal=@subtotal,cantidad=@cantidad,codigoventa=@codigoventa " +
            " where id_detalleventa=@id_detalleventa";

            SqlParameter[] objParametros = new SqlParameter[6];
            objParametros[0] = new SqlParameter("@id_venta", id_ventaX);
            objParametros[1] = new SqlParameter("@id_repuesto", id_repuestoX);
            objParametros[2] = new SqlParameter("@subtotal", subtotalX);
            objParametros[3] = new SqlParameter("@cantidad", cantidadX);
            objParametros[4] = new SqlParameter("@codigoventa", codigoventaX);
            objParametros[5] = new SqlParameter("@id_detalleventa", id_detalleventaX);

            Conexion.InsertarModificar(consultaSqlY, objParametros);
        }
        #endregion
    }
}
