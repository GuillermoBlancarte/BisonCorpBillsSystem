using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BisonCorp
{
    public partial class Clientes : Form
    {
        conexionSQLN cn = new conexionSQLN();

        public Clientes()
        {
            InitializeComponent();
            dataGridView1.DataSource = cn.ConsultaCL();
        }

        private void btn_cerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_añadir_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (!cn.ClienteExistente(tb_codigo.Text))
                {
                    //nom,apel,tel,correo,cod,desc,cant
                    cn.InsertarCliente(tb_nombre.Text, tb_apellidos.Text, tb_telefono.Text, tb_correo.Text, tb_codigo.Text, float.Parse(tb_descuento.Text), 0);
                    dataGridView1.DataSource = cn.ConsultaCL();
                    MessageBox.Show("¡Cliente agregado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("¡Ya existe un usuario con el mismo Codigo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                //nom,apel,tel,correo,cod,desc
                cn.ModificarCliente(tb_nombre.Text, tb_apellidos.Text, tb_codigo.Text, tb_telefono.Text, tb_correo.Text, float.Parse(tb_descuento.Text));
                dataGridView1.DataSource = cn.ConsultaCL();
                MessageBox.Show("¡Cliente modificado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (tb_codigo.Text != "")
            {
                cn.EliminarCliente(tb_codigo.Text);
                dataGridView1.DataSource = cn.ConsultaCL();
                MessageBox.Show("¡Cliente eliminado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                tb_codigo.Focus();
                errorProvider1.SetError(tb_codigo, "Ingrese el codigo del cliente");
            }
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

        private void tb_codigo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_codigo.Text))
            {
                e.Cancel = true;
                tb_codigo.Focus();
                errorProvider1.SetError(tb_codigo, "Ingrese codigo de cliente");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tb_codigo, null);
            }
        }

        private void tb_descuento_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_descuento.Text))
            {
                e.Cancel = true;
                tb_descuento.Focus();
                errorProvider1.SetError(tb_descuento, "Descuento no valido");
            }
            else
            {
                if (!float.TryParse(tb_descuento.Text, out float descuento))
                {
                    e.Cancel = true;
                    tb_descuento.Focus();
                    errorProvider1.SetError(tb_descuento, "Ingrese un número flotante válido");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(tb_descuento, null);
                }
            }
        }

        private void tb_telefono_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_telefono.Text))
            {
                e.Cancel = true;
                tb_telefono.Focus();
                errorProvider1.SetError(tb_telefono, "Ingrese un telefono");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tb_telefono, null);
            }
        }

        private void tb_correo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_correo.Text))
            {
                e.Cancel = true;
                tb_correo.Focus();
                errorProvider1.SetError(tb_correo, "Ingrese un correo");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tb_correo, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_nombre.Text = string.Empty;
            tb_apellidos.Text = string.Empty;
            tb_codigo.Text = string.Empty;
            tb_telefono.Text = string.Empty;
            tb_correo.Text = string.Empty;
            tb_descuento.Text = string.Empty;

            errorProvider1.SetError(tb_nombre, null);
            errorProvider1.SetError(tb_apellidos, null);
            errorProvider1.SetError(tb_codigo, null);
            errorProvider1.SetError(tb_telefono, null);
            errorProvider1.SetError(tb_correo, null);
            errorProvider1.SetError(tb_descuento, null);
        }
    }
}
