namespace BisonCorp
{
    partial class Clientes
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label6 = new Label();
            tb_telefono = new TextBox();
            label5 = new Label();
            tb_correo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tb_descuento = new TextBox();
            tb_codigo = new TextBox();
            tb_apellidos = new TextBox();
            tb_nombre = new TextBox();
            btn_añadir = new Button();
            btn_modificar = new Button();
            btn_eliminar = new Button();
            btn_cerrar = new Button();
            errorProvider1 = new ErrorProvider(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
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
            dataGridView1.TabIndex = 30;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tb_telefono);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tb_correo);
            groupBox1.Location = new Point(480, 294);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 90);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información de Contacto:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(175, 34);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 15;
            label6.Text = "Correo:";
            // 
            // tb_telefono
            // 
            tb_telefono.Location = new Point(6, 53);
            tb_telefono.Name = "tb_telefono";
            tb_telefono.Size = new Size(127, 23);
            tb_telefono.TabIndex = 9;
            tb_telefono.Validating += tb_telefono_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 35);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 14;
            label5.Text = "Telefono:";
            // 
            // tb_correo
            // 
            tb_correo.Location = new Point(175, 53);
            tb_correo.Name = "tb_correo";
            tb_correo.Size = new Size(127, 23);
            tb_correo.TabIndex = 8;
            tb_correo.Validating += tb_correo_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(370, 328);
            label4.Name = "label4";
            label4.Size = new Size(66, 16);
            label4.TabIndex = 28;
            label4.Text = "Descuento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(250, 328);
            label3.Name = "label3";
            label3.Size = new Size(49, 16);
            label3.TabIndex = 27;
            label3.Text = "Codigo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(131, 328);
            label2.Name = "label2";
            label2.Size = new Size(59, 16);
            label2.TabIndex = 26;
            label2.Text = "Apellidos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 328);
            label1.Name = "label1";
            label1.Size = new Size(54, 16);
            label1.TabIndex = 25;
            label1.Text = "Nombre:";
            // 
            // tb_descuento
            // 
            tb_descuento.Location = new Point(370, 347);
            tb_descuento.Name = "tb_descuento";
            tb_descuento.Size = new Size(102, 23);
            tb_descuento.TabIndex = 24;
            tb_descuento.Validating += tb_descuento_Validating;
            // 
            // tb_codigo
            // 
            tb_codigo.Location = new Point(250, 347);
            tb_codigo.Name = "tb_codigo";
            tb_codigo.Size = new Size(102, 23);
            tb_codigo.TabIndex = 23;
            tb_codigo.Validating += tb_codigo_Validating;
            // 
            // tb_apellidos
            // 
            tb_apellidos.Location = new Point(131, 347);
            tb_apellidos.Name = "tb_apellidos";
            tb_apellidos.Size = new Size(102, 23);
            tb_apellidos.TabIndex = 22;
            tb_apellidos.Validating += tb_apellidos_Validating;
            // 
            // tb_nombre
            // 
            tb_nombre.Location = new Point(12, 347);
            tb_nombre.Name = "tb_nombre";
            tb_nombre.Size = new Size(102, 23);
            tb_nombre.TabIndex = 21;
            tb_nombre.Validating += tb_nombre_Validating;
            // 
            // btn_añadir
            // 
            btn_añadir.Location = new Point(12, 393);
            btn_añadir.Name = "btn_añadir";
            btn_añadir.Size = new Size(127, 45);
            btn_añadir.TabIndex = 20;
            btn_añadir.Text = "Nuevo Cliente";
            btn_añadir.UseVisualStyleBackColor = true;
            btn_añadir.Click += btn_añadir_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.Location = new Point(145, 393);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(127, 45);
            btn_modificar.TabIndex = 19;
            btn_modificar.Text = "Modificar Cliente";
            btn_modificar.UseVisualStyleBackColor = true;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(278, 393);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(127, 45);
            btn_eliminar.TabIndex = 18;
            btn_eliminar.Text = "Eliminar Cliente";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Location = new Point(691, 393);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(97, 45);
            btn_cerrar.TabIndex = 17;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = true;
            btn_cerrar.Click += btn_cerrar_Click_1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            button1.Location = new Point(588, 393);
            button1.Name = "button1";
            button1.Size = new Size(97, 45);
            button1.TabIndex = 31;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_descuento);
            Controls.Add(tb_codigo);
            Controls.Add(tb_apellidos);
            Controls.Add(tb_nombre);
            Controls.Add(btn_añadir);
            Controls.Add(btn_modificar);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_cerrar);
            Name = "Clientes";
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label6;
        private TextBox tb_telefono;
        private Label label5;
        private TextBox tb_correo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tb_descuento;
        private TextBox tb_codigo;
        private TextBox tb_apellidos;
        private TextBox tb_nombre;
        private Button btn_añadir;
        private Button btn_modificar;
        private Button btn_eliminar;
        private Button btn_cerrar;
        private ErrorProvider errorProvider1;
        private Button button1;
    }
}