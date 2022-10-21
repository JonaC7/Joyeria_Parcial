using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joyeria_Parcial.PL
{
    public partial class Compras : Form
    {
      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID_compra.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtID_Producto.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtCodigo_producto.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtId_proveedor.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();






            }

            catch
            {

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           

                Con.Open();
                string insertar = "INSERT INTO ALUMNO (CODIGO,NOMBRES,APELLIDOS,DIRECCION) VALUES(@CODIGO, @NOMBRES, @APELLIDOS, @DIRECCION)";

                SqlCommand cmd1 = new SqlCommand(insertar, Con.Open());
                cmd1.Parameters.AddWithValue("@CODIGO", txtID_compra.Text);
                cmd1.Parameters.AddWithValue("@NOMBRES", txtID_Producto.Text);
                cmd1.Parameters.AddWithValue("@APELLIDOS", txtCodigo_producto.Text);
                cmd1.Parameters.AddWithValue("@DIRECCION", txtId_proveedor.Text);

                cmd1.ExecuteNonQuery();

                MessageBox.Show("los datos fueron agregados con exito");

                dataGridView1.DataSource = llenar_grid();


           
        }
    }

}