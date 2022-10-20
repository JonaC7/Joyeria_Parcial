using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joyeria_Parcial.BLL
{
    public class EmpleadosBLL
    {
        private int id_empleado;
        private string nombres;
        private string apellidos;
        private string telefono;
        private string email;
        private int id_sede;

        public EmpleadosBLL(int id)
        {
            this.id_empleado = id;
        }

        public EmpleadosBLL(int id_empleado, string nombres, string apellidos, string telefono, string email, int id_sede)
        {
            this.Id_empleado = id_empleado;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Telefono = telefono;
            this.Email = email;
            this.Id_sede = id_sede;
        }

        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public int Id_sede { get => id_sede; set => id_sede = value; }
    }
}
