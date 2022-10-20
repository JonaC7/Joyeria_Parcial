using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joyeria_Parcial.BLL
{
    public class ProveedoraBLL
    {
        private int id_proveedor;
        private string nombre_proveedor;
        private string producto_proveedor;
        private string nombres_repartidor;
        private string apellidos_repartidor;
        private string telefono_proveedor;
        private string direccion_proveedor;

        public ProveedoraBLL(int id)
        {
            this.Id_proveedor = id;
        }

        public ProveedoraBLL(int id_proveedor, string nombre_proveedor, string producto_proveedor, string nombres_repartidor, string apellidos_repartidor, string telefono_proveedor, string direccion_proveedor)
        {
            this.Id_proveedor = id_proveedor;
            this.Nombre_proveedor = nombre_proveedor;
            this.Producto_proveedor = producto_proveedor;
            this.Nombres_repartidor = nombres_repartidor;
            this.Apellidos_repartidor = apellidos_repartidor;
            this.Telefono_proveedor = telefono_proveedor;
            this.Direccion_proveedor = direccion_proveedor;
        }

        public int Id_proveedor { get => id_proveedor; set => id_proveedor = value; }
        public string Nombre_proveedor { get => nombre_proveedor; set => nombre_proveedor = value; }
        public string Producto_proveedor { get => producto_proveedor; set => producto_proveedor = value; }
        public string Nombres_repartidor { get => nombres_repartidor; set => nombres_repartidor = value; }
        public string Apellidos_repartidor { get => apellidos_repartidor; set => apellidos_repartidor = value; }
        public string Telefono_proveedor { get => telefono_proveedor; set => telefono_proveedor = value; }
        public string Direccion_proveedor { get => direccion_proveedor; set => direccion_proveedor = value; }
    }
}
