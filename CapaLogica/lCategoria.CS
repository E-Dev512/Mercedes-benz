using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using capaDatos;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Text.RegularExpressions;

namespace CapaLogica
{
    public class lCategoria
    {
        private int ID;
        private string Nombre;

        public int id
        {
            get { return ID; }
            set { ID = value; }
        }

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        cDatos oCategoria = new cDatosSQL();
        public string mensaje;
        public DataTable Listar(int val)
        {
            return oCategoria.TraerDataTable("sp_ObtenerCategorias", val);  
        }
        public DataTable Buscar(string Cont)
        {
            return oCategoria.TraerDataTable("sp_BuscarCategoria", Cont);
        }
        public bool Insertar()
        {
            DataRow oFila = oCategoria.TraerDataRow("sp_InsertarCategoria", nombre);
            mensaje = oFila["MENSAJE"].ToString();
            byte CodError = Convert.ToByte(oFila["CODERROR"].ToString());
            if (CodError == 0)
            {
                return true;
            }
            else { return false; }
        }
        public bool Eliminar()
        {
            DataRow oFila = oCategoria.TraerDataRow("sp_EliminarCategoria", id);
            mensaje = oFila["MENSAJE"].ToString();
            byte CodError = Convert.ToByte(oFila["CODERROR"].ToString());
            if (CodError == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Modificar()
        {
            DataRow oFila = oCategoria.TraerDataRow("sp_ModificarCategoria", id, nombre);
            mensaje = oFila["MENSAJE"].ToString();
            byte CodError = Convert.ToByte(oFila["CODERROR"].ToString());
            if (CodError == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int Valor()
        {
            return Convert.ToInt32(oCategoria.TraerValor("sp_ObtenerTotalCategorias"));
        }
    }
}
