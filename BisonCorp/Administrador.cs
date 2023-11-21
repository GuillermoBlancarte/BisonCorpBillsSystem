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
                if (cn.conSQL(tb_usuario.Text, tb_contrase�a.Text) == 1)
                {
                    MessageBox.Show("El usuario ha iniciado sesi�n", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    this.Hide();

                    Principal v1 = new Principal();
                    v1.Show();

                }
                else
                {
                    MessageBox.Show("�Usuario y/o contrase�a invalidos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void tb_contrase�a_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_contrase�a.Text))
            {
                e.Cancel = true;
                tb_contrase�a.Focus();
                errorProvider1.SetError(tb_contrase�a, "Ingrese contrase�a");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tb_contrase�a, null);
            }
        }
    }
}