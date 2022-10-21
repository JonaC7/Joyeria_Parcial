using Joyeria_Parcial.BLL;
using Joyeria_Parcial.DALL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joyeria_Parcial.DAL
{
    public class SedesDAL
    {
        private Database db;
        public SedesDAL()
        {
            db = new Database();
        }

        public DataTable getAllSedes()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = db.getConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Sedes";
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

        public bool createSedes(ComprasBLL compras, EmpleadosBLL empleados, ProductosBLL productos, ProveedoraBLL proveedora, SedesBLL sede, VentasBLL ventas)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Empleados (Id_sede, Nombre_sede, Ubicacion, Telefono) VALUES (@Id_sed, @Nombre_sed, @Ubic, @Tel);";
                    cmd.Parameters.AddWithValue("@Id_sed", sede.Id_sede);
                    cmd.Parameters.AddWithValue("@Nombre_sed", sede.Nombre_sede);
                    cmd.Parameters.AddWithValue("@Ubic", sede.Ubicacion);
                    cmd.Parameters.AddWithValue("@Tel", sede.Telefono);
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

        public bool updateSedes(ComprasBLL compras, EmpleadosBLL empleados, ProductosBLL productos, ProveedoraBLL proveedora, SedesBLL sede, VentasBLL ventas)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Empleados (Id_sede, Nombre_sede, Ubicacion, Telefono) VALUES (@Id_sed, @Nombre_sed, @Ubic, @Tel);";
                    cmd.Parameters.AddWithValue("@Id_sed", sede.Id_sede);
                    cmd.Parameters.AddWithValue("@Nombre_sed", sede.Nombre_sede);
                    cmd.Parameters.AddWithValue("@Ubic", sede.Ubicacion);
                    cmd.Parameters.AddWithValue("@Tel", sede.Telefono);
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

        public bool deleteSedes(SedesBLL sede)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "DELETE FROM Sedes WHERE id = @Id_sed;";
                    cmd.Parameters.AddWithValue("@Id_sed", sede.Id_sede);
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
