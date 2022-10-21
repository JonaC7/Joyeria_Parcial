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
    public class ProveedoraDAL
    {
        private Database db;
        public ProveedoraDAL()
        {
            db = new Database();
        }

        public DataTable getAllProveedora()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = db.getConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Productos";
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

        public bool createProveedora(ComprasBLL compras, EmpleadosBLL empleados, ProductosBLL productos, ProveedoraBLL proveedora, SedesBLL sede, VentasBLL ventas)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Empleados (Id_proveedor, Nombre_proveedor, Producto_proveedor, Nombres_repartidor, Apellidos_repartidor, Telefono_proveedor, Producto_proveedor, Direccion_proveedor) VALUES (@Id_prov @Nombre_prov, @Producto_prov, @Nombres_repart @Apellidos_repart @Telefono_prov, @Producto_prov, @Direccion_prov);";
                    cmd.Parameters.AddWithValue("Id_prov", proveedora.Id_proveedor);
                    cmd.Parameters.AddWithValue("@Nombre_prov", proveedora.Nombre_proveedor);
                    cmd.Parameters.AddWithValue("@Producto_prov", proveedora.Producto_proveedor);
                    cmd.Parameters.AddWithValue("@Nombres_repart", proveedora.Nombres_repartidor);
                    cmd.Parameters.AddWithValue("@Apellidos_repart", proveedora.Apellidos_repartidor);
                    cmd.Parameters.AddWithValue("@Telefono_prov", proveedora.Telefono_proveedor);
                    cmd.Parameters.AddWithValue("@Producto_prov", proveedora.Producto_proveedor);
                    cmd.Parameters.AddWithValue("@Direccion_prov", proveedora.Direccion_proveedor);
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

        public bool updateProveedora(ComprasBLL compras, EmpleadosBLL empleados, ProductosBLL productos, ProveedoraBLL proveedora, SedesBLL sede, VentasBLL ventas)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Empleados (Id_proveedor, Nombre_proveedor, Producto_proveedor, Nombres_repartidor, Apellidos_repartidor, Telefono_proveedor, Producto_proveedor, Direccion_proveedor) VALUES (@Id_prov @Nombre_prov, @Producto_prov, @Nombres_repart @Apellidos_repart @Telefono_prov, @Producto_prov, @Direccion_prov);";
                    cmd.Parameters.AddWithValue("Id_prov", proveedora.Id_proveedor);
                    cmd.Parameters.AddWithValue("@Nombre_prov", proveedora.Nombre_proveedor);
                    cmd.Parameters.AddWithValue("@Producto_prov", proveedora.Producto_proveedor);
                    cmd.Parameters.AddWithValue("@Nombres_repart", proveedora.Nombres_repartidor);
                    cmd.Parameters.AddWithValue("@Apellidos_repart", proveedora.Apellidos_repartidor);
                    cmd.Parameters.AddWithValue("@Telefono_prov", proveedora.Telefono_proveedor);
                    cmd.Parameters.AddWithValue("@Producto_prov", proveedora.Producto_proveedor);
                    cmd.Parameters.AddWithValue("@Direccion_prov", proveedora.Direccion_proveedor);
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

        public bool deleteProveedora(ProveedoraBLL proveedora)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "DELETE FROM Proveedora WHERE id = @Id_prov;";
                    cmd.Parameters.AddWithValue("Id_prov", proveedora.Id_proveedor);
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
