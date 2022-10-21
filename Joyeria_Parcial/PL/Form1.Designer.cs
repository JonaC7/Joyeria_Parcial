
namespace Joyeria_Parcial
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.joyeriaDataSet = new Joyeria_Parcial.joyeriaDataSet();
            this.joyeriaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbmTablas = new System.Windows.Forms.ComboBox();
            this.lblEscoja = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.joyeriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joyeriaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // joyeriaDataSet
            // 
            this.joyeriaDataSet.DataSetName = "joyeriaDataSet";
            this.joyeriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // joyeriaDataSetBindingSource
            // 
            this.joyeriaDataSetBindingSource.DataSource = this.joyeriaDataSet;
            this.joyeriaDataSetBindingSource.Position = 0;
            // 
            // cbmTablas
            // 
            this.cbmTablas.FormattingEnabled = true;
            this.cbmTablas.Items.AddRange(new object[] {
            "Compras",
            "Empleados",
            "productos",
            "Proveedora",
            "Sedes",
            "Ventanas"});
            this.cbmTablas.Location = new System.Drawing.Point(134, 104);
            this.cbmTablas.Name = "cbmTablas";
            this.cbmTablas.Size = new System.Drawing.Size(160, 21);
            this.cbmTablas.TabIndex = 0;
            // 
            // lblEscoja
            // 
            this.lblEscoja.AutoSize = true;
            this.lblEscoja.Location = new System.Drawing.Point(131, 51);
            this.lblEscoja.Name = "lblEscoja";
            this.lblEscoja.Size = new System.Drawing.Size(163, 13);
            this.lblEscoja.TabIndex = 1;
            this.lblEscoja.Text = "Escoja que tabla quiere modificar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 197);
            this.Controls.Add(this.lblEscoja);
            this.Controls.Add(this.cbmTablas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.joyeriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joyeriaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private joyeriaDataSet joyeriaDataSet;
        private System.Windows.Forms.BindingSource joyeriaDataSetBindingSource;
        private System.Windows.Forms.ComboBox cbmTablas;
        private System.Windows.Forms.Label lblEscoja;
    }
}

