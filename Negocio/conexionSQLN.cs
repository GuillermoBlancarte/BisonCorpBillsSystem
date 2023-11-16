using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class conexionSQLN
    {
        readonly ConexionSQL cn = new ConexionSQL();

        public int conSQL(string usr, string pass)
        {

            return cn.consultalogin(usr, pass);
            
        }

        public DataTable ConsultaDT()
        {
            return cn.ConsultaUsuariosDG();
        }

        public DataTable ConsultaFT()
        {
            return cn.ConsultaFacturas();
        }

        public DataTable DatosFacturacion(int id)
        {
            return cn.Facturacion(id);
        }

        public int InsertarUsuario(string nom, string apel, string dni, string tel, string user, string pass)
        {
            return cn.InsertarUsuario(nom, apel, dni, tel, user, pass);
        }

        public int ModificarUsuario(string nom, string apel, string dni, string tel, string user, string pass)
        {
            return cn.ModificarUsuario(nom, apel, dni, tel, user, pass);
        }

        public int EliminarUsuario(string dni)
        {
            return cn.EliminarUsuario(dni);
        }

        public bool UsuarioExistente(string dni)
        {
            return cn.UsuarioExistente(dni);
        }

        public string consultaFactura()
        {
            return cn.consultafactura();
        }

        public Tuple<string, string> consultainventario(string codigo)
        {
            return cn.consultainventario(codigo);
        }
        public Tuple<string, double> consultacliente(string codigo)
        {
            return cn.consultaCliente(codigo);
        }

        public void InsertarFactura(List<Factura> F)
        {
            cn.insertarFactura(F);
        }




    }
}
