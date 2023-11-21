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

        private void btn_añadir_Click(object sender, EventArgs e)
        {

            if (!cn.UsuarioExistente(tb_dni.Text))
            {
                //nom,apel,dni,tel,user,pass
                cn.InsertarUsuario(tb_nombre.Text, tb_apellidos.Text, tb_dni.Text, tb_telefono.Text, tb_usuario.Text, tb_contrasena.Text);
                dataGridView1.DataSource = cn.ConsultaDT();
                MessageBox.Show("¡Usuario añadido!", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("¡Usuario Modificado!", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("¡No se puede modificar al Administrador!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (tb_dni.Text != "1909997")
            {
                cn.EliminarUsuario(tb_dni.Text);
                dataGridView1.DataSource = cn.ConsultaDT();
                MessageBox.Show("¡Usuario Eliminado!", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void tb_nombre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_nombre.Text))
            {
                e.Cancel = true;
                tb_nombre.Focus();
                errorProvider1.SetError(tb_nombre, "Ingrese Nombre del Cliente");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tb_nombre, null);
            }
        }

        private void tb_apellidos_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_apellidos.Text))
            {
                e.Cancel = true;
                tb_apellidos.Focus();
                errorProvider1.SetError(tb_apellidos, "Ingrese Apellidos del Cliente");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tb_apellidos, null);
            }
        }

        private void tb_dni_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_dni.Text))
            {
                e.Cancel = true;
                tb_dni.Focus();
                errorProvider1.SetError(tb_dni, "Falta DNI");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tb_dni, null);
            }
        }

        private void tb_telefono_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_telefono.Text))
            {
                e.Cancel = true;
                tb_telefono.Focus();
                errorProvider1.SetError(tb_telefono, "Falta telefono");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tb_telefono, null);
            }
        }

        private void bt_limpiar_Click(object sender, EventArgs e)
        {
            tb_nombre.Text = string.Empty;
            tb_apellidos.Text = string.Empty;
            tb_dni.Text = string.Empty;
            tb_telefono.Text = string.Empty;
            tb_usuario.Text = string.Empty;
            tb_contrasena.Text = string.Empty;

            errorProvider1.SetError(tb_nombre, null);
            errorProvider1.SetError(tb_apellidos, null);
            errorProvider1.SetError(tb_dni, null);
            errorProvider1.SetError(tb_telefono, null);
            errorProvider1.SetError(tb_usuario, null);
            errorProvider1.SetError(tb_contrasena, null);
        }
    }
}
