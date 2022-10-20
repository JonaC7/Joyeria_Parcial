using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joyeria_Parcial.BLL
{
    public class SedesBLL
    {
        private int id_sede;
        private string nombre_sede;
        private string ubicacion;
        private string telefono;

        public SedesBLL(int id)
        {
            this.id_sede = id;
        }
        public SedesBLL(int id_sede, string nombre_sede, string ubicacion, string telefono)
        {

            this.Id_sede = id_sede;
            this.Nombre_sede = nombre_sede;
            this.Ubicacion = ubicacion;
            this.Telefono = telefono;
        }

        public int Id_sede { get => id_sede; set => id_sede = value; }
        public string Nombre_sede { get => nombre_sede; set => nombre_sede = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
