
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 373);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.joyeriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joyeriaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private joyeriaDataSet joyeriaDataSet;
        private System.Windows.Forms.BindingSource joyeriaDataSetBindingSource;
    }
}

