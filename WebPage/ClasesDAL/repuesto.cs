using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesDAL
{
    public class repuesto
    {
        //Declaración de variables
        string consultaSqlY = "";
        //Métodos implementados para la clase DAL Repuesto
        #region REPUESTO
        //public DataTable GetTodosRepuestos()
        //{
        //    consultaSqlY = "select *" +
        //                   " from repuesto";
        //    return Conexion.GetEjecutarSelect(consultaSqlY);
        //}
        public DataTable GetTodosRepuestos()
        {
            consultaSqlY = "select r.id_repuesto, r.codigo, r.descripcion, r.marca, r.industria, r.precio,prv.casacomercial" +
                           " from repuesto r,proveedor prv,proveedorrepuesto pr" +
                           " where r.id_repuesto = pr.id_repuesto " +
                           " and pr.id_proveedor = prv.id_proveedor";
            return Conexion.GetEjecutarSelect(consultaSqlY);
        }
        public DataTable GetMarcaRepuestos()
        {
            consultaSqlY = "select distinct marca " +
                           " from repuesto";
            return Conexion.GetEjecutarSelect(consultaSqlY);
        }
        public DataTable GetIndustriaRepuestos()
        {
            consultaSqlY = "select distinct industria" +
                           " from repuesto";
            return Conexion.GetEjecutarSelect(consultaSqlY);
        }

        public DataTable GetRepuestoByCriterio(string codigoX, string descripcionX, string marcaX, string industriaX)
        {
            string byCodigoX = "";
            string byDescripcionX = "";
            string byMarcaX = "";
            string byIndustriaX = "";

            if (codigoX != "") byCodigoX = " r.codigo like '" + codigoX + "%'";
            if (descripcionX != "") byDescripcionX = " r.descripcion like '" + descripcionX + "%'";
            if (marcaX != "") byMarcaX = " r.marca = '" + marcaX + "'";
            if (industriaX != "") byIndustriaX = " r.industria = '" + industriaX + "'";

            consultaSqlY = "select *" +
                           " from repuesto r" +
                           " where " + byCodigoX + byDescripcionX + byMarcaX + byIndustriaX;

            return Conexion.GetEjecutarSelect(consultaSqlY);
        }
        public DataTable GetRepuestoByCriterio2(string codigoX, string descripcionX, string marcaX, string industriaX)
        {
            string byCodigoX = "";
            string byDescripcionX = "";
            string byMarcaX = "";
            string byIndustriaX = "";

            if (codigoX != "") byCodigoX = " r.codigo like '" + codigoX + "%'";
            if (descripcionX != "") byDescripcionX = "or r.descripcion like '" + descripcionX + "%'";
            if (marcaX != "") byMarcaX = "or r.marca = '" + marcaX + "'";
            if (industriaX != "") byIndustriaX = "or r.industria = '" + industriaX + "'";

            consultaSqlY = "select *" +
                           " from repuesto r" +
                           " where " + byCodigoX + byDescripcionX + byMarcaX + byIndustriaX;

            return Conexion.GetEjecutarSelect(consultaSqlY);
        }
        public void InsertarRepuesto(string codigoX, string descricpionX, string marcaX, string industriaX, decimal precioX,string imagenX)
        {
            consultaSqlY = "INSERT INTO REPUESTO(codigo,descripcion,marca,industria,precio,imagen)" +
            " VALUES (@codigo,@descripcion,@marca,@industria,@precio,@imagen)";

            SqlParameter[] objParametros = new SqlParameter[6];
            objParametros[0] = new SqlParameter("@codigo", codigoX);
            objParametros[1] = new SqlParameter("@descripcion", descricpionX);
            objParametros[2] = new SqlParameter("@marca", marcaX);
            objParametros[3] = new SqlParameter("@industria", industriaX);
            objParametros[4] = new SqlParameter("@precio", precioX);
            objParametros[5] = new SqlParameter("@imagen", imagenX);

            Conexion.InsertarModificar(consultaSqlY, objParametros);
        }
        public void ModificarRepuesto(int id_repuestoX, string codigoX, string descricpionX, string marcaX, string industriaX, decimal precioX,string imagenX)
        {
            consultaSqlY = "update REPUESTO set codigo=@codigo,descripcion=@descripcion,marca=@marca,industria=@industria, " +
            " precio=@precio, imagen=@imagen where id_repuesto=@id_repuesto";

            SqlParameter[] objParametros = new SqlParameter[7];
            objParametros[0] = new SqlParameter("@codigo", codigoX);
            objParametros[1] = new SqlParameter("@descripcion", descricpionX);
            objParametros[2] = new SqlParameter("@marca", marcaX);
            objParametros[3] = new SqlParameter("@industria", industriaX);
            objParametros[4] = new SqlParameter("@precio", precioX);
            objParametros[5] = new SqlParameter("@imagen", imagenX);
            objParametros[6] = new SqlParameter("@id_repuesto", id_repuestoX);

            Conexion.InsertarModificar(consultaSqlY, objParametros);
        }
        public void eliminarRepuesto(int id_repuestoX)
        {
            consultaSqlY = "delete from REPUESTO where id_repuesto =" + id_repuestoX;
            Conexion.Eliminar(consultaSqlY);
        }
        #endregion
    }
}
