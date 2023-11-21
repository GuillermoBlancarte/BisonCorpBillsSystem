using System.Windows.Forms;
using Negocio;


namespace BisonCorp
{
    public partial class Administrador : Form
    {
        conexionSQLN cn = new conexionSQLN();

        public Administrador()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (cn.conSQL(tb_usuario.Text, tb_contraseña.Text) == 1)
                {
                    MessageBox.Show("El usuario ha iniciado sesión", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    this.Hide();

                    Principal v1 = new Principal();
                    v1.Show();

                }
                else
                {
                    MessageBox.Show("¡Usuario y/o contraseña invalidos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void tb_usuario_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_usuario.Text))
            {
                e.Cancel = true;
                tb_usuario.Focus();
                errorProvider1.SetError(tb_usuario, "Ingrese usuario");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tb_usuario, null);
            }
        }

        private void tb_contraseña_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_contraseña.Text))
            {
                e.Cancel = true;
                tb_contraseña.Focus();
                errorProvider1.SetError(tb_contraseña, "Ingrese contraseña");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tb_contraseña, null);
            }
        }
    }
}