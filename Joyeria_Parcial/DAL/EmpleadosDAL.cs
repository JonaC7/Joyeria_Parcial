using Joyeria_Parcial.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joyeria_Parcial.DALL
{
    public class EmpleadosDAL
    {
        private Database db;
        public EmpleadosDAL()
        {
            db = new Database();
        }

        public DataTable getAllEmpleados()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = db.getConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Empleados";
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    con.Close();
                    return dt;
                }
            }
            catch
            {
                return dt;
            }
        }

        public bool createEmpleado(ComprasBLL compras, EmpleadosBLL empleados, ProductosBLL productos, ProveedoraBLL proveedora, SedesBLL sede, VentasBLL ventas)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Empleados (nombres, apellidos, email, telefono, id_sede, id_empleado, id_cargo) VALUES (@nom, @ap, @em, @tel, @idS, @id_emp, @idC);";
                    cmd.Parameters.AddWithValue("@nom", empleados.Nombres);
                    cmd.Parameters.AddWithValue("@ap", empleados.Apellidos);
                    cmd.Parameters.AddWithValue("@em", empleados.Email);
                    cmd.Parameters.AddWithValue("@tel", empleados.Telefono);
                    cmd.Parameters.AddWithValue("@idS", sede.Id_sede);
                    cmd.Parameters.AddWithValue("@id_emp", empleados.Id_empleado);
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.GetBaseException());
                return false;
            }
        }

        public bool updateEmpleado(ComprasBLL compras, EmpleadosBLL empleados, ProductosBLL productos, ProveedoraBLL proveedora, SedesBLL sede, VentasBLL ventas)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Empleados (nombres, apellidos, email, telefono, id_sede, id_empleado, id_cargo) VALUES (@nom, @ap, @em, @tel, @idS, @id_emp, @idC);";
                    cmd.Parameters.AddWithValue("@nom", empleados.Nombres);
                    cmd.Parameters.AddWithValue("@ap", empleados.Apellidos);
                    cmd.Parameters.AddWithValue("@em", empleados.Email);
                    cmd.Parameters.AddWithValue("@tel", empleados.Telefono);
                    cmd.Parameters.AddWithValue("@idS", sede.Id_sede);
                    cmd.Parameters.AddWithValue("@id_emp", empleados.Id_empleado);
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool deleteEmpleado(EmpleadosBLL empleados)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "DELETE FROM Empleados WHERE id = @id_emp;";
                    cmd.Parameters.AddWithValue("@id_emp", empleados.Id_empleado);
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
