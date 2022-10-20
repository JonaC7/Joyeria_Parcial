using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joyeria_Parcial.BLL
{
    public class productosBLL
    {
        private int id_producto;
        private string nombre_producto;
        private int codigo_producto;
        private string precio;

        public productosBLL(int id)
        {
            this.Id_producto = id;
        }

        public productosBLL(int id_producto, string nombre_producto, int codigo_producto, string precio)
        {
            this.Id_producto = id_producto;
            this.Nombre_producto = nombre_producto;
            this.Codigo_producto = codigo_producto;
            this.Precio = precio;
        }

        public int Id_producto { get => id_producto; set => id_producto = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public int Codigo_producto { get => codigo_producto; set => codigo_producto = value; }
        public string Precio { get => precio; set => precio = value; }
    }
}
