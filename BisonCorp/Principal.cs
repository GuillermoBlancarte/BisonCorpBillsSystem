using Negocio;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace BisonCorp
{
    public partial class Principal : Form
    {
        private DataTable dt;
        conexionSQLN cn = new conexionSQLN();
        private double subtotal = 0;
        private double total = 0;
        private double desc = 0;
        private string cliente = "";

        public Principal()
        {
            InitializeComponent();
            tb_imp.Text = tb_imp_edit.Text;
            tb_desc.Text = tb_desc_edit.Text;

            dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Producto");
            dt.Columns.Add("Precio por Unidad");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Descuento");
            dt.Columns.Add("Precio Total");

            dtg_fact.DataSource = dt;

            tb_nfactura.Text = cn.consultaFactura();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsers v1 = new FormUsers();
            this.Hide();
            v1.ShowDialog();
            this.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            this.Hide();
            clientes.ShowDialog();
            this.Show();
        }

        private void ImpYDescCambio(object sender, EventArgs e)
        {
            tb_imp.Text = tb_imp_edit.Text;
            tb_desc.Text = tb_desc_edit.Text;
        }


        private void bt_AgregarProdcuto_Click(object sender, EventArgs e)
        {
            var resultado = cn.consultainventario(tb_CodigoProducto.Text);

            if (resultado == null || resultado.Item1 == "NULL" || resultado.Item2 == "NULL")
            {
                MessageBox.Show("No se encontró el producto en el inventario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow row = dt.NewRow();

            row["Codigo"] = tb_CodigoProducto.Text;
            row["Precio por Unidad"] = resultado.Item2;
            row["Producto"] = resultado.Item1;
            row["Cantidad"] = tb_Cantidad.Text;
            row["Descuento"] = tb_desc.Text;
            row["Precio Total"] = Int32.Parse(tb_Cantidad.Text) * double.Parse(resultado.Item2);

            dt.Rows.Add(row);

            subtotal = subtotal + (Int32.Parse(tb_Cantidad.Text) * double.Parse(resultado.Item2));


            if (desc == 0)
            {
                total = subtotal + (subtotal * double.Parse(tb_imp_edit.Text));
            }
            else
            {
                total = subtotal + (subtotal * double.Parse(tb_imp_edit.Text));
                total = total - (total * desc);
            }

            lb_sub.Text = subtotal.ToString();
            lb_total.Text = total.ToString();

        }

        private void bt_buscarCliente_Click(object sender, EventArgs e)
        {
            var resultado = cn.consultacliente(tb_CodigoCliente.Text);
            tb_Cliente.Text = resultado.Item1 + " DESC: " + resultado.Item2;
            cliente = resultado.Item1;
            desc = resultado.Item2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Factura> listFact = new List<Factura>();

            foreach (DataRow row in dt.Rows)
            {
                Factura factura = new Factura();

                factura.Codigo = row["Codigo"].ToString();
                factura.Precio_por_Unidad = row["Precio por Unidad"].ToString();
                factura.Producto = row["Producto"].ToString();
                factura.Cantidad = row["Cantidad"].ToString();
                factura.Descuento = row["Descuento"].ToString();
                factura.Precio_Total = row["Precio Total"].ToString();
                factura.Subtotal = subtotal.ToString();
                factura.Cliente = cliente.ToString();
                factura.Desc = desc.ToString();
                factura.Total = total.ToString();
                factura.NFactura = tb_nfactura.Text;

                listFact.Add(factura);


            }

            cn.InsertarFactura(listFact);
            tb_nfactura.Text = cn.consultaFactura();
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();
            MessageBox.Show("¡Factura registrada!", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 12);
            int ancho = 300;
            int y = 20;

            e.Graphics.DrawString("--- BisonCorp ---", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("N° Factura: " + tb_nfactura, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Cliente: " + cliente.ToString(), font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("--- Productos ---", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            foreach (DataRow row in dt.Rows)
            {
                e.Graphics.DrawString(row["Codigo"].ToString() + " " +
                    row["Producto"].ToString() + " " +
                    row["Precio Total"].ToString()
                    , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            }
            e.Graphics.DrawString("Subtotal: " + subtotal.ToString(), font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("--- Total: $" + total.ToString(), font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Gracias por su compra " + cliente.ToString(), font, Brushes.Black, new RectangleF(0, y += 35, ancho, 20));
        }

        private void historialDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInovice v1 = new FormInovice();
            this.Hide();
            v1.ShowDialog();
            this.Show();
        }

        private void bt_ReiniciarCodigo_Click(object sender, EventArgs e)
        {
            tb_Cliente.Text = string.Empty;
            tb_CodigoCliente.Text = string.Empty;
        }

        private void dtg_fact_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            subtotal = 0;
            foreach (DataGridViewRow row in dtg_fact.Rows)
            {
                if (row.Cells["Cantidad"].Value != null)
                {
                    subtotal = subtotal + Convert.ToInt32(row.Cells["Cantidad"].Value) * Convert.ToDouble(row.Cells["Precio por Unidad"].Value);
                }
            }

            if (desc == 0)
            {
                total = subtotal + (subtotal * double.Parse(tb_imp_edit.Text));
            }
            else
            {
                total = subtotal + (subtotal * double.Parse(tb_imp_edit.Text));
                total = total - (total * desc);
            }

            if (subtotal == 0)
            {
                lb_sub.Text = "0.00";
                lb_total.Text = "0.00";
            }
            else
            {
                lb_sub.Text = subtotal.ToString();
                lb_total.Text = total.ToString();
            }

        }
    }
}
