namespace busquedaBinaria
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
            this.txtResBus = new System.Windows.Forms.TextBox();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtLlenar = new System.Windows.Forms.TextBox();
            this.cmdLlenar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResBus
            // 
            this.txtResBus.Location = new System.Drawing.Point(189, 80);
            this.txtResBus.Multiline = true;
            this.txtResBus.Name = "txtResBus";
            this.txtResBus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResBus.Size = new System.Drawing.Size(226, 172);
            this.txtResBus.TabIndex = 9;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(256, 49);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(75, 23);
            this.cmdBuscar.TabIndex = 8;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click_1);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(244, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 7;
            // 
            // txtLlenar
            // 
            this.txtLlenar.Location = new System.Drawing.Point(65, 51);
            this.txtLlenar.Multiline = true;
            this.txtLlenar.Name = "txtLlenar";
            this.txtLlenar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLlenar.Size = new System.Drawing.Size(118, 201);
            this.txtLlenar.TabIndex = 6;
            // 
            // cmdLlenar
            // 
            this.cmdLlenar.Location = new System.Drawing.Point(88, 23);
            this.cmdLlenar.Name = "cmdLlenar";
            this.cmdLlenar.Size = new System.Drawing.Size(75, 23);
            this.cmdLlenar.TabIndex = 5;
            this.cmdLlenar.Text = "Llenar";
            this.cmdLlenar.UseVisualStyleBackColor = true;
            this.cmdLlenar.Click += new System.EventHandler(this.cmdLlenar_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 274);
            this.Controls.Add(this.txtResBus);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtLlenar);
            this.Controls.Add(this.cmdLlenar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResBus;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtLlenar;
        private System.Windows.Forms.Button cmdLlenar;
    }
}

