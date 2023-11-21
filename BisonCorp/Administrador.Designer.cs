namespace BisonCorp
{
    partial class Administrador
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            tb_contraseña = new TextBox();
            label2 = new Label();
            tb_usuario = new TextBox();
            label3 = new Label();
            btn_entrar = new Button();
            btn_salir = new Button();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 211);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 30);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("VCR OSD Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(181, 5);
            label1.Name = "label1";
            label1.Size = new Size(88, 16);
            label1.TabIndex = 0;
            label1.Text = "BisonCorp";
            // 
            // tb_contraseña
            // 
            tb_contraseña.Location = new Point(181, 120);
            tb_contraseña.Name = "tb_contraseña";
            tb_contraseña.Size = new Size(88, 23);
            tb_contraseña.TabIndex = 1;
            tb_contraseña.UseSystemPasswordChar = true;
            tb_contraseña.Validating += tb_contraseña_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 102);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "Contraseña:";
            // 
            // tb_usuario
            // 
            tb_usuario.Location = new Point(181, 59);
            tb_usuario.Name = "tb_usuario";
            tb_usuario.Size = new Size(88, 23);
            tb_usuario.TabIndex = 3;
            tb_usuario.Validating += tb_usuario_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(181, 41);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 4;
            label3.Text = "Usuario:";
            // 
            // btn_entrar
            // 
            btn_entrar.Location = new Point(121, 169);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(75, 23);
            btn_entrar.TabIndex = 5;
            btn_entrar.Text = "Entrar";
            btn_entrar.UseVisualStyleBackColor = true;
            btn_entrar.Click += btn_entrar_Click;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(256, 169);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(75, 23);
            btn_salir.TabIndex = 6;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 241);
            Controls.Add(btn_salir);
            Controls.Add(btn_entrar);
            Controls.Add(label3);
            Controls.Add(tb_usuario);
            Controls.Add(label2);
            Controls.Add(tb_contraseña);
            Controls.Add(panel1);
            Name = "Administrador";
            Text = "Admin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox tb_contraseña;
        private Label label2;
        private TextBox tb_usuario;
        private Label label3;
        private Button btn_entrar;
        private Button btn_salir;
        private ErrorProvider errorProvider1;
    }
}