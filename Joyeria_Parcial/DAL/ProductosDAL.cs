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
    public class ProductosDAL
    {
        private Database db;
        public ProductosDAL()
        {
            db = new Database();
        }

        public DataTable getAllProductos()
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

        public bool createProductos(ComprasBLL compras, EmpleadosBLL empleados, ProductosBLL productos, ProveedoraBLL proveedora, SedesBLL sede, VentasBLL ventas)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Empleados (nombres, apellidos, email, telefono, id_sede, id_empleado, id_cargo) VALUES (@Id_produc @Nombre_produc, @Codigo_produc, @Preci);";
                    cmd.Parameters.AddWithValue("Id_produc", productos.Id_producto);
                    cmd.Parameters.AddWithValue("@Nombre_produc", productos.Nombre_producto);
                    cmd.Parameters.AddWithValue("@Codigo_produc", productos.Codigo_producto);
                    cmd.Parameters.AddWithValue("@Preci", productos.Precio);
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

        public bool updateProductos(ComprasBLL compras, EmpleadosBLL empleados, ProductosBLL productos, ProveedoraBLL proveedora, SedesBLL sede, VentasBLL ventas)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Empleados (nombres, apellidos, email, telefono, id_sede, id_empleado, id_cargo) VALUES (@Id_produc @Nombre_produc, @Codigo_produc, @Preci);";
                    cmd.Parameters.AddWithValue("Id_produc", productos.Id_producto);
                    cmd.Parameters.AddWithValue("@Nombre_produc", productos.Nombre_producto);
                    cmd.Parameters.AddWithValue("@Codigo_produc", productos.Codigo_producto);
                    cmd.Parameters.AddWithValue("@Preci", productos.Precio);
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

        public bool deleteProductos(ProductosBLL productos)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "DELETE FROM Productos WHERE id = @Id_produc;";
                    cmd.Parameters.AddWithValue("@Id_produc", productos.Id_producto);
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
