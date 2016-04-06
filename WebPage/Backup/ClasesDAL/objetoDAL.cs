using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesDAL
{
    public class objetoDAL
    {
        int id_repuesto;

        public int ID_REPUESTO
        {
            get { return id_repuesto; }
            set { id_repuesto = value; }
        }
        string codigo;

        public string CODIGO
        {
            get { return codigo; }
            set { codigo = value; }
        }
        string descripcion;

        public string DESCRIPCION
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        decimal precio;

        public decimal PRECIO
        {
            get { return precio; }
            set { precio = value; }
        }
        int cantidad;

        public int CANTIDAD
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        decimal subtotal;

        public decimal SUBTOTAL
        {
            get { return subtotal; }
            set { subtotal = value; }
        }
    }
}
