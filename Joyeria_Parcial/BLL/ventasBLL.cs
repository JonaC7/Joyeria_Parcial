using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joyeria_Parcial.BLL
{
    public class VentasBLL
    {
        private int id_venta;
        private int id_producto;
        private int codigo_producto;
        private string precio;
        private int id_empleado;

        public VentasBLL(int id)
        {
            this.Id_venta = id;
        }

        public VentasBLL(int id_venta, int id_producto, int codigo_producto, string precio, int id_empleado)
        {
            this.Id_venta = id_venta;
            this.Id_producto = id_producto;
            this.Codigo_producto = codigo_producto;
            this.Precio = precio;
            this.Id_empleado = id_empleado;
        }

        public int Id_venta { get => id_venta; set => id_venta = value; }
        public int Id_producto { get => id_producto; set => id_producto = value; }
        public int Codigo_producto { get => codigo_producto; set => codigo_producto = value; }
        public string Precio { get => precio; set => precio = value; }
        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
    }
}
