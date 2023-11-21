namespace BisonCorp
{
    partial class FormInovice
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
            label1 = new Label();
            tb_factura = new TextBox();
            btn_Facturar = new Button();
            btn_cerrar = new Button();
            label2 = new Label();
            tb_nombre = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tb_RFC = new TextBox();
            label5 = new Label();
            label6 = new Label();
            tb_Domicilio = new TextBox();
            label7 = new Label();
            Dup_CFDI = new DomainUpDown();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            Dup_RF = new DomainUpDown();
            groupBox1 = new GroupBox();
            errorProvider1 = new ErrorProvider(components);
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
            dataGridView1.Size = new Size(770, 313);
            dataGridView1.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 345);
            label1.Name = "label1";
            label1.Size = new Size(66, 16);
            label1.TabIndex = 25;
            label1.Text = "N° Factura:";
            // 
            // tb_factura
            // 
            tb_factura.Location = new Point(12, 364);
            tb_factura.Name = "tb_factura";
            tb_factura.Size = new Size(102, 23);
            tb_factura.TabIndex = 21;
            tb_factura.Validating += tb_factura_Validating;
            // 
            // btn_Facturar
            // 
            btn_Facturar.Location = new Point(12, 393);
            btn_Facturar.Name = "btn_Facturar";
            btn_Facturar.Size = new Size(102, 45);
            btn_Facturar.TabIndex = 20;
            btn_Facturar.Text = "Facturar";
            btn_Facturar.UseVisualStyleBackColor = true;
            btn_Facturar.Click += btn_Facturar_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Location = new Point(691, 393);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(97, 45);
            btn_cerrar.TabIndex = 17;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = true;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 25);
            label2.Name = "label2";
            label2.Size = new Size(54, 16);
            label2.TabIndex = 32;
            label2.Text = "Nombre:";
            // 
            // tb_nombre
            // 
            tb_nombre.Location = new Point(15, 44);
            tb_nombre.Name = "tb_nombre";
            tb_nombre.Size = new Size(102, 23);
            tb_nombre.TabIndex = 31;
            tb_nombre.Validating += tb_nombre_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(123, 25);
            label3.Name = "label3";
            label3.Size = new Size(89, 16);
            label3.TabIndex = 34;
            label3.Text = "Regimen Fiscal:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(231, 25);
            label4.Name = "label4";
            label4.Size = new Size(37, 16);
            label4.TabIndex = 36;
            label4.Text = "R.F.C.";
            // 
            // tb_RFC
            // 
            tb_RFC.Location = new Point(231, 44);
            tb_RFC.Name = "tb_RFC";
            tb_RFC.Size = new Size(102, 23);
            tb_RFC.TabIndex = 35;
            tb_RFC.Validating += tb_RFC_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(339, 25);
            label5.Name = "label5";
            label5.Size = new Size(32, 16);
            label5.TabIndex = 38;
            label5.Text = "CFDI";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(447, 25);
            label6.Name = "label6";
            label6.Size = new Size(61, 16);
            label6.TabIndex = 40;
            label6.Text = "Domicilio:";
            // 
            // tb_Domicilio
            // 
            tb_Domicilio.Location = new Point(447, 44);
            tb_Domicilio.Name = "tb_Domicilio";
            tb_Domicilio.Size = new Size(102, 23);
            tb_Domicilio.TabIndex = 39;
            tb_Domicilio.Validating += tb_Domicilio_Validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(447, 70);
            label7.Name = "label7";
            label7.Size = new Size(104, 13);
            label7.TabIndex = 41;
            label7.Text = "Solo codigo postal";
            // 
            // Dup_CFDI
            // 
            Dup_CFDI.Location = new Point(339, 45);
            Dup_CFDI.Name = "Dup_CFDI";
            Dup_CFDI.Size = new Size(102, 23);
            Dup_CFDI.TabIndex = 42;
            Dup_CFDI.Text = "CLAVE";
            Dup_CFDI.Validating += Dup_CFDI_Validating;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Dup_RF
            // 
            Dup_RF.Location = new Point(123, 44);
            Dup_RF.Name = "Dup_RF";
            Dup_RF.Size = new Size(102, 23);
            Dup_RF.TabIndex = 43;
            Dup_RF.Text = "CLAVE";
            Dup_RF.Validating += Dup_RF_Validating;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb_nombre);
            groupBox1.Controls.Add(tb_Domicilio);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(Dup_RF);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(Dup_CFDI);
            groupBox1.Controls.Add(tb_RFC);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(120, 346);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(565, 92);
            groupBox1.TabIndex = 45;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información Requerida:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormInovice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(tb_factura);
            Controls.Add(btn_Facturar);
            Controls.Add(btn_cerrar);
            Name = "FormInovice";
            Text = " Facturas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox tb_factura;
        private Button btn_Facturar;
        private Button btn_cerrar;
        private Label label2;
        private TextBox tb_nombre;
        private Label label3;
        private Label label4;
        private TextBox tb_RFC;
        private Label label5;
        private Label label6;
        private TextBox tb_Domicilio;
        private Label label7;
        private DomainUpDown Dup_CFDI;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DomainUpDown Dup_RF;
        private GroupBox groupBox1;
        private ErrorProvider errorProvider1;
    }
}