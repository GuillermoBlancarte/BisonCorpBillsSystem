using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Negocio;

namespace BisonCorp
{
    public partial class FormUsers : Form
    {
        conexionSQLN cn = new conexionSQLN();
        public FormUsers()
        {
            InitializeComponent();
            dataGridView1.DataSource = cn.ConsultaDT();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {

        }

        private void btn_añadir_Click(object sender, EventArgs e)
        {

            if (!cn.UsuarioExistente(tb_dni.Text))
            {
                //nom,apel,dni,tel,user,pass
                cn.InsertarUsuario(tb_nombre.Text,tb_apellidos.Text,tb_dni.Text,tb_telefono.Text,tb_usuario.Text,tb_contrasena.Text);
                dataGridView1.DataSource = cn.ConsultaDT();
            }
            else
            {
                MessageBox.Show("¡Ya existe un usuario con el mismo DNI!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (tb_dni.Text != "1909997")
            {
                //nom,apel,dni,tel,user,pass
                cn.ModificarUsuario(tb_nombre.Text, tb_apellidos.Text, tb_dni.Text, tb_telefono.Text, tb_usuario.Text, tb_contrasena.Text);
                dataGridView1.DataSource = cn.ConsultaDT();
            }
            else
            {
                MessageBox.Show("¡No se puede modificar al Administrador!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if(tb_dni.Text != "1909997")
            {
                cn.EliminarUsuario(tb_dni.Text);
                dataGridView1.DataSource = cn.ConsultaDT();
            }
            else
            {
                MessageBox.Show("¡No se puede eliminar al Administrador!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }


        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
