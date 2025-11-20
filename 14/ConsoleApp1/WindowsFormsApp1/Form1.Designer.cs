namespace WindowsFormsApp1
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
            this.lblcadena = new System.Windows.Forms.Label();
            this.textcadena = new System.Windows.Forms.TextBox();
            this.textS = new System.Windows.Forms.TextBox();
            this.btnACEPTAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcadena
            // 
            this.lblcadena.AutoSize = true;
            this.lblcadena.Location = new System.Drawing.Point(54, 38);
            this.lblcadena.Name = "lblcadena";
            this.lblcadena.Size = new System.Drawing.Size(43, 13);
            this.lblcadena.TabIndex = 0;
            this.lblcadena.Text = "cadena";
            // 
            // textcadena
            // 
            this.textcadena.Location = new System.Drawing.Point(117, 35);
            this.textcadena.Name = "textcadena";
            this.textcadena.Size = new System.Drawing.Size(382, 20);
            this.textcadena.TabIndex = 1;
            // 
            // textS
            // 
            this.textS.Location = new System.Drawing.Point(60, 78);
            this.textS.Multiline = true;
            this.textS.Name = "textS";
            this.textS.Size = new System.Drawing.Size(439, 256);
            this.textS.TabIndex = 2;
            // 
            // btnACEPTAR
            // 
            this.btnACEPTAR.Location = new System.Drawing.Point(526, 30);
            this.btnACEPTAR.Name = "btnACEPTAR";
            this.btnACEPTAR.Size = new System.Drawing.Size(93, 29);
            this.btnACEPTAR.TabIndex = 3;
            this.btnACEPTAR.Text = "aceptar";
            this.btnACEPTAR.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnACEPTAR);
            this.Controls.Add(this.textS);
            this.Controls.Add(this.textcadena);
            this.Controls.Add(this.lblcadena);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcadena;
        private System.Windows.Forms.TextBox textcadena;
        private System.Windows.Forms.TextBox textS;
        private System.Windows.Forms.Button btnACEPTAR;
    }
}

