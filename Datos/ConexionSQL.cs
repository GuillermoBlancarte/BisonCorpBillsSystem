using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class ConexionSQL
    {
        //static string conexionstring = "server= localhost; database= Administracion;" + "integrated security= true";
        //static string conexionstring = "Data Source=DESKTOP-5J4G6PL;Initial Catalog=Administracion;Integrated Security=True";
        static string conexionstring = "Data Source=.;Initial Catalog=Administracion;Integrated Security=True";
        SqlConnection con = new SqlConnection(conexionstring);

        public int consultalogin(string usuario, string contrasena)
        {
            int contador;
            con.Open();
            string Query = "Select Count(*) From Persona where usuario = '"+usuario +"'" +
                " and contrasena= '"+contrasena+"'";
            SqlCommand cmd = new SqlCommand(Query, con);
            contador = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return contador;
        }

        public DataTable ConsultaUsuariosDG()
        {
            string query = "select * from Persona";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }

        public DataTable ConsultaFacturas()
        {
            string query = "select * from Facturacion";
            SqlCommand sql = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(sql);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }

        public DataTable ConsultaClientes()
        {
            string query = "select * from Clientes";
            SqlCommand sql = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(sql);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }

        public DataTable Facturacion(int id)
        {
            string query = "select * from Facturacion where NumFactura = "+id;
            SqlCommand sql = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(sql);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }

        public int InsertarUsuario(string nom, string apel, string dni, string tel, string user, string pass)
        {
            int flag = 0;
            con.Open();
            string query = "insert into Persona values ('" + nom + "','" + apel + "','" + dni + "','" + tel + "','" + user + "','" + pass + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public int InsertarCliente(string nom, string apel, string tel, string correo, string codigo, float dec, int cant)
        {
            int flag = 0;
            con.Open();
            string query = "insert into Clientes values ('" + nom + "','" + apel + "','" + tel + "','" + correo + "','" + codigo + "'," + dec + "," + cant + ")";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public int ModificarUsuario(string nom, string apel, string dni, string tel, string user, string pass)
        {
            int flag = 0;
            con.Open() ;
            string query = "Update Persona set nombre = '" + nom + "', apellidos = '" + apel + "',telefono = '" + tel + "',usuario ='" + user + "',contrasena = '" + pass+ "' where dni = '"+ dni + "'";
            SqlCommand cmd = new SqlCommand(query,con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public int ModificarCliente(string nom, string apel, string codigo, string tel, string correo, float desc)
        {
            int flag = 0;
            con.Open();
            string query = "Update Clientes set Nombre = '" + nom + "', Apellido = '" + apel + "',Telefono = '" + tel + "',Correo ='" + correo + "',Descuento = " + desc + " where Codigo = '" + codigo + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public int EliminarUsuario(string dni)
        {   
            int flag = 0;
            con.Open();
            string query = "Delete from Persona where dni = '" + dni + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;

        }

        public int EliminarCliente(string codigo)
        {
            int flag = 0;
            con.Open();
            string query = "Delete from Clientes where Codigo = '" + codigo + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;

        }

        public bool UsuarioExistente(string dni)
        {
            int contador;
            con.Open();
            //string query = "Select count(*) from Persona where dni = '" + dni + "'";
            string query = "Select count(*) from Persona where dni = @dni";
            using(SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@dni", dni);
                contador = (int)cmd.ExecuteScalar();
            }
            //SqlCommand cmd = new SqlCommand(query, con);
            //contador = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close() ;
            return contador > 0;                
        }

        public bool ClienteExistente(string codigo)
        {
            int contador;
            con.Open();
            string query = "Select count(*) from Clientes where Codigo = @Codigo";
            using(SqlCommand cmd = new SqlCommand (query, con))
            {
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                contador = (int)cmd.ExecuteScalar();
            }
            con.Close() ;
            return contador > 0;
        }

        public string consultafactura()
        {
            con.Open();
            string resultado = "0";
            string query = "Select (Select distinct top 1 NumFactura from Facturacion order by NumFactura desc) + 1 as NumFactura";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
               resultado = reader["NumFactura"].ToString();
            }

            con.Close();
            return resultado;
        }

        public Tuple<string,string> consultainventario(string codigo)
        {
            con.Open();
            string resultado = "NULL";
            string resultado2 = "NULL";
            string query = "Select * from Inventario where Codigo = '"+codigo +"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                resultado = reader["Producto"].ToString();
                resultado2 = reader["Precio"].ToString();
            }

            con.Close();
            return Tuple.Create(resultado, resultado2);
        }

        public Tuple<string, double> consultaCliente(string codigo)
        {
            con.Open();
            string resultado = "NULL";
            double resultado2 = 0;
            string query = "  Select [Nombre] + ' '+[Apellido] as Nombre , [Descuento] from [Clientes] where [Codigo] = '"+codigo+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                resultado = reader["Nombre"].ToString();
                resultado2 = double.Parse(reader["Descuento"].ToString());
            }

            con.Close();
            return Tuple.Create(resultado, resultado2);
        }

        public  void insertarFactura(List<Factura> F)
        {
            con.Open();

            foreach (Factura fact in F)
            {
                string query = "insert into Facturacion (Codigo,Producto,PrecioxUnidad,Cantidad,Descuento,Cliente, DescuentoCliente, MontoTotal, NumFactura ) values ('" + fact.Codigo + "','" + fact.Producto + "'," + Convert.ToDouble(fact.Precio_por_Unidad) + "," + Convert.ToInt32(fact.Cantidad) + "," + Convert.ToDouble(fact.Descuento) + ",'" + fact.Cliente + "'," + Convert.ToDouble(fact.Desc) + "," + Convert.ToDouble(fact.Total) + "," + Convert.ToInt32(fact.NFactura) + ")";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }

            con.Close ();
        }

    }
}
