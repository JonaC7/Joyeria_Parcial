using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joyeria_Parcial.BLL
{
    public class comprasBLL
    {
        private int id_compra;
        private int id_producto;
        private int codigo_producto;
        private string precio;
        private int id_proveedor;

        public comprasBLL(int id)
        {
            this.id_compra = id;
        }

        public comprasBLL(int id_compra, int id_producto, int codigo_producto, string precio, int id_proveedor)
        {
            this.id_compra = id_compra;
            this.id_producto = id_producto;
            this.codigo_producto = codigo_producto;
            this.precio = precio;
            this.id_proveedor = id_proveedor;
        }

        public int Id_compra { get => id_compra; set => id_compra = value; }
        public int Id_producto { get => id_producto; set => id_producto = value; }
        public int Codigo_producto { get => codigo_producto; set => codigo_producto = value; }
        public string Precio { get => precio; set => precio = value; }
        public int Id_proveedor { get => id_proveedor; set => id_proveedor = value; }

        
    }
}
