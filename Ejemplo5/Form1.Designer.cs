
namespace Ejemplo5
{
    partial class Ejemplo5
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
            this.timerMov = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timerMov
            // 
            this.timerMov.Enabled = true;
            this.timerMov.Tick += new System.EventHandler(this.timerMov_Tick);
            // 
            // Ejemplo5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Ejemplo5";
            this.Text = "Ejemplo5";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Ejemplo5_Paint_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ejemplo5_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerMov;
    }
}

