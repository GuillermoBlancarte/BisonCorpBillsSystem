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
            if(cn.conSQL(tb_usuario.Text,tb_contrase�a.Text) == 1)
            {
                MessageBox.Show("El usuario ha iniciado sesi�n","Completado", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

                this.Hide();

                Principal v1 = new Principal();
                v1.Show();

            }
            else
            {
                MessageBox.Show("�Usuario y/o contrase�a invalidos!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}