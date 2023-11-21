using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.IO.Image;
using Image = iText.Layout.Element.Image;
using System.Diagnostics;
using iText.Layout.Borders;
using iText.Layout.Properties;
using Microsoft.VisualBasic.Logging;
using static iText.Svg.SvgConstants;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iText.Kernel.Geom;
using Path = System.IO.Path;

namespace BisonCorp
{
    public partial class FormInovice : Form
    {
        conexionSQLN cn = new conexionSQLN();

        public FormInovice()
        {
            InitializeComponent();

            string[] elementos = { "G01 Adquisicíon de mercancías",
                "G02 Devoluciones, descuentos o bonificaciones", "G03 Gastos en general", " S01 Sin Efectos Fiscales" };
            Dup_CFDI.Items.AddRange(elementos);

            string[] elementos2 = { "601 - General de Ley Personas Morales" ,
                    "603 - Personas Morales con Fines no Lucrativos" ,
                    "605 - Sueldos y Salarios e Ingresos Asimilados a Salarios" ,
                    "606 - Arrendamiento" ,
                    "607 - Régimen de Enajenación o Adquisición de Bienes" ,
                    "608 - Demás ingresos" ,
                    "609 - Consolidación" ,
                    "610 - Residentes en el Extranjero sin Establecimiento Permanente en México" ,
                    "611 - Ingresos por Dividendos (socios y accionistas)" ,
                    "612 - Personas Físicas con Actividades Empresariales y Profesionales" ,
                    "614 - Ingresos por intereses" ,
                    "615 - Régimen de los ingresos por obtención de premios" ,
                    "616 - Sin obligaciones fiscales" ,
                    "620 - Sociedades Cooperativas de Producción que optan por diferir sus ingresos" ,
                    "621 - Incorporación Fiscal" ,
                    "622 - Actividades Agrícolas, Ganaderas, Silvícolas y Pesqueras" ,
                    "623 - Opcional para Grupos de Sociedades" ,
                    "624 - Coordinados" ,
                    "625 - Régimen de las Actividades Empresariales con ingresos a través de Plataformas Tecnológicas" ,
                    "626 - Régimen Simplificado de Confianza" ,
                    "628 - Hidrocarburos" ,
                    "629 - De los Regímenes Fiscales Preferentes y de las Empresas Multinacionales" ,
                    "630 - Enajenación de acciones en bolsa de valores" };

            Dup_RF.Items.AddRange(elementos2);
            dataGridView1.DataSource = cn.ConsultaFT();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Facturar_Click(object sender, EventArgs e)
        {
            String DirectorioDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            String carpetaFacturas = Path.Combine(DirectorioDocumentos, "Facturas");
            String path = Path.Combine(carpetaFacturas, "Factura_" + tb_factura.Text + "_" + tb_nombre.Text + ".pdf");
            String imagepath = Path.Combine(DirectorioDocumentos, "Geo.jpeg");

            double subtotal = 0;

            if (!Directory.Exists(carpetaFacturas))
            {
                Directory.CreateDirectory(carpetaFacturas);
            }

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                DataTable datos = cn.DatosFacturacion(Int32.Parse(tb_factura.Text));

                PdfWriter writer = new PdfWriter(path);
                PdfDocument PDF = new PdfDocument(writer);
                Document document = new Document(PDF);

                Image logo = new Image(ImageDataFactory.Create(imagepath));
                logo.SetHeight(60);
                logo.SetWidth(60);

                float col = 300f;
                float[] colwidht = { col, col };

                Table table = new Table(colwidht);

                Cell cell11 = new Cell(1, 1)
                    .SetFontSize(14)
                    .SetBold()
                    .SetBorder(Border.NO_BORDER)
                    .Add(logo)
                    .Add(new Paragraph("BlanCorp Studio"));

                Cell cell12 = new Cell(2, 1)
                    .SetBorder(Border.NO_BORDER)
                    .SetTextAlignment(TextAlignment.RIGHT)
                    .SetFontSize(26)
                    .Add(new Paragraph("FACTURA"));

                Cell cell21 = new Cell(1, 1)
                    .SetBorder(Border.NO_BORDER)
                    .SetItalic()
                    .Add(new Paragraph("Tu diseño, nuestra pasión."));

                Table Informacion = new Table(colwidht);
                Informacion.SetMarginTop(20f);

                Cell cell31 = new Cell(1, 1)
                    .SetBorder(Border.NO_BORDER)
                    .Add(new Paragraph("Nuevo León\nApodaca, Col. Privada La Castaña\nJulian Treviño #200\n81-1596-9574\nblancorp.geometrik@gmail.com | BlanCorp Geometrik Studio"));

                Cell cell32 = new Cell(1, 1)
                    .SetTextAlignment(TextAlignment.RIGHT)
                    .SetBorder(Border.NO_BORDER)
                    .Add(new Paragraph("FACTURA # " + tb_factura.Text + "\nFecha: " + DateTime.Now.ToString("dd/MM/yyyy")));

                Cell cell41 = new Cell(1, 1)
                    .SetFontSize(8)
                    .SetBorder(Border.NO_BORDER)
                    .SetPaddingTop(20f)
                    .SetItalic()
                    .Add(new Paragraph("Cliente: \nNombre " + tb_nombre.Text + "\nRegimen Fiscal " + Dup_RF.Text + "\nR.F.C. " + tb_RFC.Text + "\nUSO CFDI " + Dup_CFDI.Text + "\nDomicilio Fiscal: " + tb_Domicilio.Text));


                Table itemTable = new Table(new float[] { 1, 1, 1, 1, 1 })
                    .SetWidth(540f)
                    .SetMarginTop(20f);

                Cell cell51 = new Cell(1, 1)
                    .SetBold()
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER)
                    .Add(new Paragraph("Cantidad"));

                Cell cell52 = new Cell(1, 1)
                    .SetBold()
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER)
                    .Add(new Paragraph("Clave del Producto"));

                Cell cell53 = new Cell(1, 1)
                    .SetBold()
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER)
                    .Add(new Paragraph("Descripción"));

                Cell cell54 = new Cell(1, 1)
                    .SetBold()
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER)
                    .Add(new Paragraph("Precio Unitario"));

                Cell cell55 = new Cell(1, 1)
                    .SetBold()
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER)
                    .Add(new Paragraph("Importe"));


                itemTable.AddCell(cell51);
                itemTable.AddCell(cell52);
                itemTable.AddCell(cell53);
                itemTable.AddCell(cell54);
                itemTable.AddCell(cell55);

                foreach (DataRow row in datos.Rows)
                {
                    Cell cell61 = new Cell(1, 1)
                        .Add(new Paragraph(row["Cantidad"].ToString()));

                    Cell cell62 = new Cell(1, 1)
                        .Add(new Paragraph(row["Codigo"].ToString()));

                    Cell cell63 = new Cell(1, 1)
                        .Add(new Paragraph(row["Producto"].ToString()));

                    Cell cell64 = new Cell(1, 1)
                        .Add(new Paragraph(row["PrecioxUnidad"].ToString()));

                    Cell cell65 = new Cell(1, 1)
                        .Add(new Paragraph(row["PrecioTotal"].ToString()));

                    itemTable.AddCell(cell61);
                    itemTable.AddCell(cell62);
                    itemTable.AddCell(cell63);
                    itemTable.AddCell(cell64);
                    itemTable.AddCell(cell65);

                    subtotal += Convert.ToDouble(row["PrecioTotal"]);

                }

                Cell cell71 = new Cell(1, 2)
                    .SetBold()
                    .SetBorder(Border.NO_BORDER)
                    .Add(new Paragraph("Subtotal:"));

                Cell cell72 = new Cell(1, 3)
                    .SetBold()
                    .SetTextAlignment(TextAlignment.RIGHT)
                    .SetBorder(Border.NO_BORDER)
                    .Add(new Paragraph(subtotal.ToString()));

                Cell cell73 = new Cell(1, 2)
                    .SetBold()
                    .SetBorder(Border.NO_BORDER)
                    .Add(new Paragraph("IVA 16%: "));

                Cell cell74 = new Cell(1, 3)
                    .SetBold()
                    .SetTextAlignment(TextAlignment.RIGHT)
                    .SetBorder(Border.NO_BORDER)
                    .Add(new Paragraph((subtotal * 0.16).ToString()));

                Cell cell75 = new Cell(1, 2)
                    .SetBold()
                    .SetBorder(Border.NO_BORDER)
                    .Add(new Paragraph("Descuentos: "));

                Cell cell76 = new Cell(1, 3)
                    .SetBold()
                    .SetTextAlignment(TextAlignment.RIGHT)
                    .SetBorder(Border.NO_BORDER)
                    .Add(new Paragraph(datos.Rows[0]["DescuentoCliente"].ToString()));

                Cell cell77 = new Cell(1, 2)
                    .SetBold()
                    .SetBorder(Border.NO_BORDER)
                    .SetBorderTop(new SolidBorder(1.5f))
                    .Add(new Paragraph("Precio Total:"));

                Cell cell78 = new Cell(1, 3)
                    .SetBold()
                    .SetBorder(Border.NO_BORDER)
                    .SetBorderTop(new SolidBorder(1.5f))
                    .SetTextAlignment(TextAlignment.RIGHT)
                    .Add(new Paragraph(datos.Rows[0]["MontoTotal"].ToString()));



                Cell cell81 = new Cell(1, 5)
                    .SetBorder(Border.NO_BORDER)
                    .SetBorderTop(new SolidBorder(1.25f))
                    .SetBold()
                    .SetPaddingTop(100f)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph("ESTO ES UNA PRUEBA"));


                table.AddCell(cell11);
                table.AddCell(cell12);
                table.AddCell(cell21);

                Informacion.AddCell(cell31);
                Informacion.AddCell(cell32);
                Informacion.AddCell(cell41);


                itemTable.AddCell(cell71);
                itemTable.AddCell(cell72);
                itemTable.AddCell(cell73);
                itemTable.AddCell(cell74);
                itemTable.AddCell(cell75);
                itemTable.AddCell(cell76);
                itemTable.AddCell(cell77);
                itemTable.AddCell(cell78);
                itemTable.AddCell(cell81);


                document.Add(table);
                document.Add(Informacion);
                document.Add(itemTable);


                document.Close();
                MessageBox.Show("Factura guardada en Documentos", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }



        }

        private void tb_Domicilio_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Domicilio.Text) || tb_Domicilio.Text.Any(c => !char.IsDigit(c)))
            {
                e.Cancel = true;
                tb_Domicilio.Focus();
                errorProvider1.SetError(tb_Domicilio, "Ingrese un codigo postal");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tb_Domicilio, null);
            }
        }

        private void tb_RFC_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_RFC.Text))
            {
                e.Cancel = true;
                tb_RFC.Focus();
                errorProvider1.SetError(tb_RFC, "Ingrese RFC");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tb_RFC, null);
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

        private void tb_factura_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_factura.Text) || tb_factura.Text.Any(c => !char.IsDigit(c)))
            {
                e.Cancel = true;
                tb_factura.Focus();
                errorProvider1.SetError(tb_factura, "Ingrese un codigo postal");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tb_factura, null);
            }
        }

        private void Dup_RF_Validating(object sender, CancelEventArgs e)
        {
            if (Dup_RF.Text == "CLAVE")
            {
                e.Cancel = true;
                errorProvider1.SetError(Dup_RF, "Clave vacia");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Dup_RF, null);
            }
        }

        private void Dup_CFDI_Validating(object sender, CancelEventArgs e)
        {
            if (Dup_CFDI.Text == "CLAVE")
            {
                e.Cancel = true;
                errorProvider1.SetError(Dup_CFDI, "Clave vacia");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Dup_CFDI, null);
            }
        }


        //private void tb_regimen_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
        //    {
        //        e.Handled = true;
        //    }
        //}
    }
}
