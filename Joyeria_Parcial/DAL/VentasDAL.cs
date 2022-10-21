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
    public class VentasDAL
    {
        private Database db;
        public VentasDAL()
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
                    cmd.CommandText = "SELECT * FROM Ventas";
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

        public bool createVentas(ComprasBLL compras, EmpleadosBLL empleados, ProductosBLL productos, ProveedoraBLL proveedora, SedesBLL sede, VentasBLL ventas)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Empleados (Id_venta, Id_producto, Codigo_producto, Precio, Id_empleado) VALUES (@Id_vent, @Id_produc, @Codigo_produc, @Preci, @Id_emp);";
                    cmd.Parameters.AddWithValue("@Id_vent", ventas.Id_venta);
                    cmd.Parameters.AddWithValue("@Id_produc", productos.Id_producto);
                    cmd.Parameters.AddWithValue("@Codigo_produc", productos.Codigo_producto);
                    cmd.Parameters.AddWithValue("@Preci", ventas.Precio);
                    cmd.Parameters.AddWithValue("@Id_emp", empleados.Id_empleado);
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

        public bool updateVentas(ComprasBLL compras, EmpleadosBLL empleados, ProductosBLL productos, ProveedoraBLL proveedora, SedesBLL sede, VentasBLL ventas)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Empleados (Id_venta, Id_producto, Codigo_producto, Precio, Id_empleado) VALUES (@Id_vent, @Id_produc, @Codigo_produc, @Preci, @Id_emp);";
                    cmd.Parameters.AddWithValue("@Id_vent", ventas.Id_venta);
                    cmd.Parameters.AddWithValue("@Id_produc", productos.Id_producto);
                    cmd.Parameters.AddWithValue("@Codigo_produc", productos.Codigo_producto);
                    cmd.Parameters.AddWithValue("@Preci", ventas.Precio);
                    cmd.Parameters.AddWithValue("@Id_emp", empleados.Id_empleado);
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

        public bool deleteVentas(VentasBLL ventas)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "DELETE FROM Ventas WHERE id = @Id_vent;";
                    cmd.Parameters.AddWithValue("@Id_vent", ventas.Id_venta);
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
