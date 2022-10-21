
namespace Joyeria_Parcial.PL
{
    partial class Compras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.lblid_compra = new System.Windows.Forms.Label();
            this.lblCodigo_producto = new System.Windows.Forms.Label();
            this.lblId_proveedor = new System.Windows.Forms.Label();
            this.txtId_proveedor = new System.Windows.Forms.TextBox();
            this.txtID_compra = new System.Windows.Forms.TextBox();
            this.txtCodigo_producto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtID_Producto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(336, 133);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 0;
            this.lblPrecio.Text = "Precio";
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Location = new System.Drawing.Point(336, 59);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(70, 13);
            this.lblIdProducto.TabIndex = 1;
            this.lblIdProducto.Text = " ID_Producto";
          
            // 
            // lblid_compra
            // 
            this.lblid_compra.AutoSize = true;
            this.lblid_compra.Location = new System.Drawing.Point(51, 63);
            this.lblid_compra.Name = "lblid_compra";
            this.lblid_compra.Size = new System.Drawing.Size(59, 13);
            this.lblid_compra.TabIndex = 2;
            this.lblid_compra.Text = "ID_compra";
            // 
            // lblCodigo_producto
            // 
            this.lblCodigo_producto.AutoSize = true;
            this.lblCodigo_producto.Location = new System.Drawing.Point(51, 129);
            this.lblCodigo_producto.Name = "lblCodigo_producto";
            this.lblCodigo_producto.Size = new System.Drawing.Size(91, 13);
            this.lblCodigo_producto.TabIndex = 3;
            this.lblCodigo_producto.Text = " Codigo_producto";
   
            // 
            // lblId_proveedor
            // 
            this.lblId_proveedor.AutoSize = true;
            this.lblId_proveedor.Location = new System.Drawing.Point(51, 196);
            this.lblId_proveedor.Name = "lblId_proveedor";
            this.lblId_proveedor.Size = new System.Drawing.Size(73, 13);
            this.lblId_proveedor.TabIndex = 4;
            this.lblId_proveedor.Text = " Id_proveedor";
            // 
            // txtId_proveedor
            // 
            this.txtId_proveedor.Location = new System.Drawing.Point(148, 189);
            this.txtId_proveedor.Name = "txtId_proveedor";
            this.txtId_proveedor.Size = new System.Drawing.Size(100, 20);
            this.txtId_proveedor.TabIndex = 5;
            // 
            // txtID_compra
            // 
            this.txtID_compra.Location = new System.Drawing.Point(148, 56);
            this.txtID_compra.Name = "txtID_compra";
            this.txtID_compra.Size = new System.Drawing.Size(100, 20);
            this.txtID_compra.TabIndex = 6;
            // 
            // txtCodigo_producto
            // 
            this.txtCodigo_producto.Location = new System.Drawing.Point(148, 122);
            this.txtCodigo_producto.Name = "txtCodigo_producto";
            this.txtCodigo_producto.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo_producto.TabIndex = 7;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(412, 122);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 8;
            // 
            // txtID_Producto
            // 
            this.txtID_Producto.Location = new System.Drawing.Point(412, 52);
            this.txtID_Producto.Name = "txtID_Producto";
            this.txtID_Producto.Size = new System.Drawing.Size(100, 20);
            this.txtID_Producto.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Registro de compras";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 150);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(437, 415);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(298, 415);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
          
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(183, 415);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(62, 415);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID_Producto);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCodigo_producto);
            this.Controls.Add(this.txtID_compra);
            this.Controls.Add(this.txtId_proveedor);
            this.Controls.Add(this.lblId_proveedor);
            this.Controls.Add(this.lblCodigo_producto);
            this.Controls.Add(this.lblid_compra);
            this.Controls.Add(this.lblIdProducto);
            this.Controls.Add(this.lblPrecio);
            this.Name = "Compras";
            this.Text = "Compras";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Label lblid_compra;
        private System.Windows.Forms.Label lblCodigo_producto;
        private System.Windows.Forms.Label lblId_proveedor;
        private System.Windows.Forms.TextBox txtId_proveedor;
        private System.Windows.Forms.TextBox txtID_compra;
        private System.Windows.Forms.TextBox txtCodigo_producto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtID_Producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGuardar;
    }
}