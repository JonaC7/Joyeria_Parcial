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
    public class ComprasDAL
    {
        private Database db;
        public ComprasDAL()
        {
            db = new Database();
        }

        public DataTable getAllCompras()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = db.getConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Compras";
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

        public bool createCompras(ComprasBLL compras, EmpleadosBLL empleados, ProductosBLL productos, ProveedoraBLL proveedora, SedesBLL sede, VentasBLL ventas)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Empleados (Id_compra, Id_producto, Codigo_producto, Precio, Id_proveedor, Id_empleado) VALUES (@Id_comp, @Id_produc, @Codigo_produ, @Preci, @Id_prov, @Id_emp);";
                    cmd.Parameters.AddWithValue("@Id_comp", compras.Id_compra);
                    cmd.Parameters.AddWithValue("@Id_produc", compras.Id_producto);
                    cmd.Parameters.AddWithValue("@Codigo_produ", compras.Codigo_producto);
                    cmd.Parameters.AddWithValue("@Preci", compras.Precio);
                    cmd.Parameters.AddWithValue("@Id_prov", proveedora.Id_proveedor);
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

        public bool updateCompras(ComprasBLL compras, EmpleadosBLL empleados, ProductosBLL productos, ProveedoraBLL proveedora, SedesBLL sede, VentasBLL ventas)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Empleados (id_compra, id_producto, codigo_producto, precio, id_proveedor, id_empleado) VALUES (@Id_comp, @Id_produc, @Codigo_produ, @Preci, @Id_prov, @Id_emp);";
                    cmd.Parameters.AddWithValue("@Id_comp", compras.Id_compra);
                    cmd.Parameters.AddWithValue("@Id_produc", compras.Id_producto);
                    cmd.Parameters.AddWithValue("@Codigo_produ", compras.Codigo_producto);
                    cmd.Parameters.AddWithValue("@Preci", compras.Precio);
                    cmd.Parameters.AddWithValue("@Id_prov", proveedora.Id_proveedor);
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

        public bool deleteCompras(ComprasBLL compras)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "DELETE FROM Compras WHERE id = @Id_comp;";
                    cmd.Parameters.AddWithValue("@Id_comp", compras.Id_compra);
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
