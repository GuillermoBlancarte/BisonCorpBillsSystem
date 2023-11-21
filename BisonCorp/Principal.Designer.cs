namespace BisonCorp
{
    partial class Principal
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
            btn_cerrar = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            abrirFacturaToolStripMenuItem = new ToolStripMenuItem();
            impuestoDeVentaToolStripMenuItem = new ToolStripMenuItem();
            tb_imp_edit = new ToolStripTextBox();
            descuentoToolStripMenuItem = new ToolStripMenuItem();
            tb_desc_edit = new ToolStripTextBox();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            inventarioToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            historialDeFacturasToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            dtg_fact = new DataGridView();
            tb_CodigoCliente = new TextBox();
            bt_buscarCliente = new Button();
            label1 = new Label();
            bt_AgregarProducto = new Button();
            tb_CodigoProducto = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lb_sub = new Label();
            label5 = new Label();
            lb_total = new Label();
            tb_desc = new TextBox();
            label7 = new Label();
            button3 = new Button();
            tb_Cantidad = new TextBox();
            label8 = new Label();
            label9 = new Label();
            tb_imp = new TextBox();
            label10 = new Label();
            tb_nfactura = new TextBox();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            tb_Cliente = new TextBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            bt_ReiniciarCodigo = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_fact).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_cerrar
            // 
            btn_cerrar.Location = new Point(713, 415);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(75, 23);
            btn_cerrar.TabIndex = 0;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = true;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Teal;
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, usuariosToolStripMenuItem, inventarioToolStripMenuItem, reportesToolStripMenuItem, clienteToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 25);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { abrirFacturaToolStripMenuItem });
            toolStripMenuItem1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripMenuItem1.ForeColor = Color.White;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(66, 21);
            toolStripMenuItem1.Text = "Archivo";
            // 
            // abrirFacturaToolStripMenuItem
            // 
            abrirFacturaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { impuestoDeVentaToolStripMenuItem, descuentoToolStripMenuItem });
            abrirFacturaToolStripMenuItem.Name = "abrirFacturaToolStripMenuItem";
            abrirFacturaToolStripMenuItem.Size = new Size(225, 22);
            abrirFacturaToolStripMenuItem.Text = "Impuestos y Descuentos";
            // 
            // impuestoDeVentaToolStripMenuItem
            // 
            impuestoDeVentaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tb_imp_edit });
            impuestoDeVentaToolStripMenuItem.Name = "impuestoDeVentaToolStripMenuItem";
            impuestoDeVentaToolStripMenuItem.Size = new Size(191, 22);
            impuestoDeVentaToolStripMenuItem.Text = "Impuesto de Venta";
            // 
            // tb_imp_edit
            // 
            tb_imp_edit.Name = "tb_imp_edit";
            tb_imp_edit.Size = new Size(100, 23);
            tb_imp_edit.Text = "0.16";
            tb_imp_edit.TextChanged += ImpYDescCambio;
            // 
            // descuentoToolStripMenuItem
            // 
            descuentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tb_desc_edit });
            descuentoToolStripMenuItem.Name = "descuentoToolStripMenuItem";
            descuentoToolStripMenuItem.Size = new Size(191, 22);
            descuentoToolStripMenuItem.Text = "Descuento";
            // 
            // tb_desc_edit
            // 
            tb_desc_edit.Name = "tb_desc_edit";
            tb_desc_edit.Size = new Size(100, 23);
            tb_desc_edit.Text = "0";
            tb_desc_edit.TextChanged += ImpYDescCambio;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            usuariosToolStripMenuItem.ForeColor = Color.White;
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(72, 21);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // inventarioToolStripMenuItem
            // 
            inventarioToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            inventarioToolStripMenuItem.ForeColor = Color.White;
            inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            inventarioToolStripMenuItem.Size = new Size(82, 21);
            inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { historialDeFacturasToolStripMenuItem });
            reportesToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            reportesToolStripMenuItem.ForeColor = Color.White;
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(74, 21);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // historialDeFacturasToolStripMenuItem
            // 
            historialDeFacturasToolStripMenuItem.Name = "historialDeFacturasToolStripMenuItem";
            historialDeFacturasToolStripMenuItem.Size = new Size(200, 22);
            historialDeFacturasToolStripMenuItem.Text = "Historial de Facturas";
            historialDeFacturasToolStripMenuItem.Click += historialDeFacturasToolStripMenuItem_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            clienteToolStripMenuItem.ForeColor = Color.White;
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(61, 21);
            clienteToolStripMenuItem.Text = "Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // dtg_fact
            // 
            dtg_fact.AllowUserToAddRows = false;
            dtg_fact.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_fact.Location = new Point(122, 57);
            dtg_fact.Name = "dtg_fact";
            dtg_fact.ReadOnly = true;
            dtg_fact.RowTemplate.Height = 25;
            dtg_fact.Size = new Size(666, 235);
            dtg_fact.TabIndex = 2;
            dtg_fact.RowsRemoved += dtg_fact_RowsRemoved;
            // 
            // tb_CodigoCliente
            // 
            tb_CodigoCliente.Location = new Point(12, 149);
            tb_CodigoCliente.Name = "tb_CodigoCliente";
            tb_CodigoCliente.Size = new Size(104, 23);
            tb_CodigoCliente.TabIndex = 3;
            // 
            // bt_buscarCliente
            // 
            bt_buscarCliente.Location = new Point(12, 178);
            bt_buscarCliente.Name = "bt_buscarCliente";
            bt_buscarCliente.Size = new Size(104, 23);
            bt_buscarCliente.TabIndex = 4;
            bt_buscarCliente.Text = "Buscar";
            bt_buscarCliente.UseVisualStyleBackColor = true;
            bt_buscarCliente.Click += bt_buscarCliente_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 131);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 5;
            label1.Text = "Codigo Cliente:";
            // 
            // bt_AgregarProducto
            // 
            bt_AgregarProducto.Location = new Point(405, 354);
            bt_AgregarProducto.Name = "bt_AgregarProducto";
            bt_AgregarProducto.Size = new Size(247, 46);
            bt_AgregarProducto.TabIndex = 6;
            bt_AgregarProducto.Text = "Agregar producto";
            bt_AgregarProducto.UseVisualStyleBackColor = true;
            bt_AgregarProducto.Click += bt_AgregarProdcuto_Click;
            // 
            // tb_CodigoProducto
            // 
            tb_CodigoProducto.Location = new Point(405, 325);
            tb_CodigoProducto.Name = "tb_CodigoProducto";
            tb_CodigoProducto.Size = new Size(126, 23);
            tb_CodigoProducto.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(409, 307);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 8;
            label2.Text = "Codigo de Producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 333);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 9;
            label3.Text = "Subtotal:";
            // 
            // lb_sub
            // 
            lb_sub.AutoSize = true;
            lb_sub.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_sub.Location = new Point(20, 351);
            lb_sub.Name = "lb_sub";
            lb_sub.Size = new Size(85, 47);
            lb_sub.TabIndex = 10;
            lb_sub.Text = "0.00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(147, 306);
            label5.Name = "label5";
            label5.Size = new Size(97, 43);
            label5.TabIndex = 11;
            label5.Text = "Total:";
            // 
            // lb_total
            // 
            lb_total.AutoSize = true;
            lb_total.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lb_total.Location = new Point(147, 351);
            lb_total.Name = "lb_total";
            lb_total.Size = new Size(121, 65);
            lb_total.TabIndex = 12;
            lb_total.Text = "0.00";
            // 
            // tb_desc
            // 
            tb_desc.Location = new Point(312, 377);
            tb_desc.Name = "tb_desc";
            tb_desc.ReadOnly = true;
            tb_desc.Size = new Size(60, 23);
            tb_desc.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(312, 357);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 14;
            label7.Text = "Descuento:";
            // 
            // button3
            // 
            button3.Location = new Point(658, 317);
            button3.Name = "button3";
            button3.Size = new Size(130, 83);
            button3.TabIndex = 15;
            button3.Text = "Facturar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tb_Cantidad
            // 
            tb_Cantidad.Location = new Point(537, 325);
            tb_Cantidad.Name = "tb_Cantidad";
            tb_Cantidad.Size = new Size(115, 23);
            tb_Cantidad.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(564, 307);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 17;
            label8.Text = "Cantidad:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(312, 307);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 19;
            label9.Text = "Impuesto:";
            // 
            // tb_imp
            // 
            tb_imp.Location = new Point(312, 325);
            tb_imp.Name = "tb_imp";
            tb_imp.ReadOnly = true;
            tb_imp.Size = new Size(60, 23);
            tb_imp.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(122, 31);
            label10.Name = "label10";
            label10.Size = new Size(66, 15);
            label10.TabIndex = 21;
            label10.Text = "N° Factura:";
            // 
            // tb_nfactura
            // 
            tb_nfactura.BackColor = SystemColors.Window;
            tb_nfactura.Location = new Point(194, 28);
            tb_nfactura.Name = "tb_nfactura";
            tb_nfactura.ReadOnly = true;
            tb_nfactura.Size = new Size(100, 23);
            tb_nfactura.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Geo;
            pictureBox1.Location = new Point(9, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(405, 31);
            label11.Name = "label11";
            label11.Size = new Size(47, 15);
            label11.TabIndex = 24;
            label11.Text = "Cliente:";
            // 
            // tb_Cliente
            // 
            tb_Cliente.BackColor = SystemColors.Window;
            tb_Cliente.Location = new Point(458, 28);
            tb_Cliente.Name = "tb_Cliente";
            tb_Cliente.ReadOnly = true;
            tb_Cliente.Size = new Size(330, 23);
            tb_Cliente.TabIndex = 23;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += Imprimir;
            // 
            // bt_ReiniciarCodigo
            // 
            bt_ReiniciarCodigo.Location = new Point(12, 207);
            bt_ReiniciarCodigo.Name = "bt_ReiniciarCodigo";
            bt_ReiniciarCodigo.Size = new Size(104, 23);
            bt_ReiniciarCodigo.TabIndex = 25;
            bt_ReiniciarCodigo.Text = "Limpiar Cliente";
            bt_ReiniciarCodigo.UseVisualStyleBackColor = true;
            bt_ReiniciarCodigo.Click += bt_ReiniciarCodigo_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_ReiniciarCodigo);
            Controls.Add(label11);
            Controls.Add(tb_Cliente);
            Controls.Add(pictureBox1);
            Controls.Add(label10);
            Controls.Add(tb_nfactura);
            Controls.Add(label9);
            Controls.Add(tb_imp);
            Controls.Add(label8);
            Controls.Add(tb_Cantidad);
            Controls.Add(button3);
            Controls.Add(label7);
            Controls.Add(tb_desc);
            Controls.Add(lb_total);
            Controls.Add(label5);
            Controls.Add(lb_sub);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tb_CodigoProducto);
            Controls.Add(bt_AgregarProducto);
            Controls.Add(label1);
            Controls.Add(bt_buscarCliente);
            Controls.Add(tb_CodigoCliente);
            Controls.Add(dtg_fact);
            Controls.Add(btn_cerrar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Principal";
            Text = "Principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_fact).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cerrar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem abrirFacturaToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem inventarioToolStripMenuItem;
        private DataGridView dtg_fact;
        private TextBox tb_CodigoCliente;
        private Button bt_buscarCliente;
        private Label label1;
        private Button bt_AgregarProducto;
        private TextBox tb_CodigoProducto;
        private Label label2;
        private Label label3;
        private Label lb_sub;
        private Label label5;
        private Label lb_total;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem historialDeFacturasToolStripMenuItem;
        private TextBox tb_desc;
        private Label label7;
        private Button button3;
        private TextBox tb_Cantidad;
        private Label label8;
        private Label label9;
        private TextBox tb_imp;
        private Label label10;
        private TextBox tb_nfactura;
        private PictureBox pictureBox1;
        private Label label11;
        private TextBox tb_Cliente;
        private ToolStripMenuItem impuestoDeVentaToolStripMenuItem;
        private ToolStripTextBox tb_imp_edit;
        private ToolStripMenuItem descuentoToolStripMenuItem;
        private ToolStripTextBox tb_desc_edit;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button bt_ReiniciarCodigo;
    }
}