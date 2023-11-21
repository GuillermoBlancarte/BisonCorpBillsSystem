namespace BisonCorp
{
    partial class FormUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btn_cerrar = new Button();
            btn_eliminar = new Button();
            btn_modificar = new Button();
            btn_añadir = new Button();
            tb_nombre = new TextBox();
            tb_apellidos = new TextBox();
            tb_dni = new TextBox();
            tb_telefono = new TextBox();
            tb_contrasena = new TextBox();
            tb_usuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            bt_limpiar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btn_cerrar
            // 
            btn_cerrar.Location = new Point(691, 393);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(97, 45);
            btn_cerrar.TabIndex = 0;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = true;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(278, 393);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(127, 45);
            btn_eliminar.TabIndex = 1;
            btn_eliminar.Text = "Eliminar Usuario";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.Location = new Point(145, 393);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(127, 45);
            btn_modificar.TabIndex = 2;
            btn_modificar.Text = "Modificar Usuario";
            btn_modificar.UseVisualStyleBackColor = true;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // btn_añadir
            // 
            btn_añadir.Location = new Point(12, 393);
            btn_añadir.Name = "btn_añadir";
            btn_añadir.Size = new Size(127, 45);
            btn_añadir.TabIndex = 3;
            btn_añadir.Text = "Nuevo Usuario";
            btn_añadir.UseVisualStyleBackColor = true;
            btn_añadir.Click += btn_añadir_Click;
            // 
            // tb_nombre
            // 
            tb_nombre.Location = new Point(12, 347);
            tb_nombre.Name = "tb_nombre";
            tb_nombre.Size = new Size(102, 23);
            tb_nombre.TabIndex = 4;
            tb_nombre.Validating += tb_nombre_Validating;
            // 
            // tb_apellidos
            // 
            tb_apellidos.Location = new Point(131, 347);
            tb_apellidos.Name = "tb_apellidos";
            tb_apellidos.Size = new Size(102, 23);
            tb_apellidos.TabIndex = 5;
            tb_apellidos.Validating += tb_apellidos_Validating;
            // 
            // tb_dni
            // 
            tb_dni.Location = new Point(250, 347);
            tb_dni.Name = "tb_dni";
            tb_dni.Size = new Size(102, 23);
            tb_dni.TabIndex = 6;
            tb_dni.Validating += tb_dni_Validating;
            // 
            // tb_telefono
            // 
            tb_telefono.Location = new Point(370, 347);
            tb_telefono.Name = "tb_telefono";
            tb_telefono.Size = new Size(102, 23);
            tb_telefono.TabIndex = 7;
            tb_telefono.Validating += tb_telefono_Validating;
            // 
            // tb_contrasena
            // 
            tb_contrasena.Location = new Point(175, 53);
            tb_contrasena.Name = "tb_contrasena";
            tb_contrasena.Size = new Size(127, 23);
            tb_contrasena.TabIndex = 8;
            // 
            // tb_usuario
            // 
            tb_usuario.Location = new Point(6, 53);
            tb_usuario.Name = "tb_usuario";
            tb_usuario.Size = new Size(127, 23);
            tb_usuario.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 328);
            label1.Name = "label1";
            label1.Size = new Size(54, 16);
            label1.TabIndex = 10;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(131, 328);
            label2.Name = "label2";
            label2.Size = new Size(59, 16);
            label2.TabIndex = 11;
            label2.Text = "Apellidos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(250, 328);
            label3.Name = "label3";
            label3.Size = new Size(30, 16);
            label3.TabIndex = 12;
            label3.Text = "DNI:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(370, 328);
            label4.Name = "label4";
            label4.Size = new Size(57, 16);
            label4.TabIndex = 13;
            label4.Text = "Telefono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 35);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 14;
            label5.Text = "Usuario:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tb_usuario);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tb_contrasena);
            groupBox1.Location = new Point(480, 294);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 90);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información de Acceso:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(175, 34);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 15;
            label6.Text = "Contraseña:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(770, 264);
            dataGridView1.TabIndex = 16;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // bt_limpiar
            // 
            bt_limpiar.Location = new Point(588, 393);
            bt_limpiar.Name = "bt_limpiar";
            bt_limpiar.Size = new Size(97, 45);
            bt_limpiar.TabIndex = 17;
            bt_limpiar.Text = "Limpiar";
            bt_limpiar.UseVisualStyleBackColor = true;
            bt_limpiar.Click += bt_limpiar_Click;
            // 
            // FormUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_limpiar);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_telefono);
            Controls.Add(tb_dni);
            Controls.Add(tb_apellidos);
            Controls.Add(tb_nombre);
            Controls.Add(btn_añadir);
            Controls.Add(btn_modificar);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_cerrar);
            Name = "FormUsers";
            Text = "Usuarios";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cerrar;
        private Button btn_eliminar;
        private Button btn_modificar;
        private Button btn_añadir;
        private TextBox tb_nombre;
        private TextBox tb_apellidos;
        private TextBox tb_dni;
        private TextBox tb_telefono;
        private TextBox tb_contrasena;
        private TextBox tb_usuario;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private Label label6;
        private DataGridView dataGridView1;
        private ErrorProvider errorProvider1;
        private Button bt_limpiar;
    }
}