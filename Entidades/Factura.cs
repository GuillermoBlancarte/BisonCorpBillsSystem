using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        private string codigo = "";
        private string precio_por_Unidad = "";
        private string producto = "";
        private string cantidad = "";
        private string descuento = "";
        private string precio_Total = "";
        private string subtotal = "";
        private string cliente = "";
        private string desc = "";
        private string total = "";
        private string nFactura = "";

        public string Codigo { get => codigo; set => codigo = value; }
        public string Precio_por_Unidad { get => precio_por_Unidad; set => precio_por_Unidad = value; }
        public string Producto { get => producto; set => producto = value; }
        public string Cantidad { get => cantidad; set => cantidad = value; }
        public string Descuento { get => descuento; set => descuento = value; }
        public string Precio_Total { get => precio_Total; set => precio_Total = value; }
        public string Subtotal { get => subtotal; set => subtotal = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Desc { get => desc; set => desc = value; }
        public string Total { get => total; set => total = value; }
        public string NFactura { get => nFactura; set => nFactura = value; }
    }



}
