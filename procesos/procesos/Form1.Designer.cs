namespace procesos
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmdInicio = new System.Windows.Forms.Button();
            this.lblNumProTot = new System.Windows.Forms.Label();
            this.lblProPend = new System.Windows.Forms.Label();
            this.lblNumMaxPro = new System.Windows.Forms.Label();
            this.lblNumVacia = new System.Windows.Forms.Label();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.txtRestantes = new System.Windows.Forms.TextBox();
            this.txtVacios = new System.Windows.Forms.TextBox();
            this.txtAtendidos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 23);
            this.label1.TabIndex = 75;
            this.label1.Text = "Tiempo de los procesos: ";
            // 
            // cmdInicio
            // 
            this.cmdInicio.Location = new System.Drawing.Point(21, 43);
            this.cmdInicio.Name = "cmdInicio";
            this.cmdInicio.Size = new System.Drawing.Size(172, 23);
            this.cmdInicio.TabIndex = 74;
            this.cmdInicio.Text = "Simular ";
            this.cmdInicio.UseVisualStyleBackColor = true;
            this.cmdInicio.Click += new System.EventHandler(this.cmdInicio_Click);
            // 
            // lblNumProTot
            // 
            this.lblNumProTot.AutoSize = true;
            this.lblNumProTot.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumProTot.Location = new System.Drawing.Point(12, 148);
            this.lblNumProTot.Name = "lblNumProTot";
            this.lblNumProTot.Size = new System.Drawing.Size(198, 23);
            this.lblNumProTot.TabIndex = 79;
            this.lblNumProTot.Text = "¿Cuantos se atendieron?";
            // 
            // lblProPend
            // 
            this.lblProPend.AutoSize = true;
            this.lblProPend.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProPend.Location = new System.Drawing.Point(12, 238);
            this.lblProPend.Name = "lblProPend";
            this.lblProPend.Size = new System.Drawing.Size(161, 23);
            this.lblProPend.TabIndex = 78;
            this.lblProPend.Text = "¿Cuantos quedaron?";
            // 
            // lblNumMaxPro
            // 
            this.lblNumMaxPro.AutoSize = true;
            this.lblNumMaxPro.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumMaxPro.Location = new System.Drawing.Point(12, 102);
            this.lblNumMaxPro.Name = "lblNumMaxPro";
            this.lblNumMaxPro.Size = new System.Drawing.Size(332, 23);
            this.lblNumMaxPro.TabIndex = 77;
            this.lblNumMaxPro.Text = "Número máximo  de procesos formados : ";
            // 
            // lblNumVacia
            // 
            this.lblNumVacia.AutoSize = true;
            this.lblNumVacia.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumVacia.Location = new System.Drawing.Point(12, 193);
            this.lblNumVacia.Name = "lblNumVacia";
            this.lblNumVacia.Size = new System.Drawing.Size(139, 23);
            this.lblNumVacia.TabIndex = 76;
            this.lblNumVacia.Text = "¿Cuantos vacios?";
            // 
            // txtMaximo
            // 
            this.txtMaximo.Location = new System.Drawing.Point(16, 125);
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Size = new System.Drawing.Size(100, 20);
            this.txtMaximo.TabIndex = 80;
            // 
            // txtRestantes
            // 
            this.txtRestantes.Location = new System.Drawing.Point(21, 264);
            this.txtRestantes.Name = "txtRestantes";
            this.txtRestantes.Size = new System.Drawing.Size(100, 20);
            this.txtRestantes.TabIndex = 81;
            // 
            // txtVacios
            // 
            this.txtVacios.Location = new System.Drawing.Point(16, 219);
            this.txtVacios.Name = "txtVacios";
            this.txtVacios.Size = new System.Drawing.Size(100, 20);
            this.txtVacios.TabIndex = 82;
            // 
            // txtAtendidos
            // 
            this.txtAtendidos.Location = new System.Drawing.Point(16, 174);
            this.txtAtendidos.Name = "txtAtendidos";
            this.txtAtendidos.Size = new System.Drawing.Size(100, 20);
            this.txtAtendidos.TabIndex = 83;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 299);
            this.Controls.Add(this.txtAtendidos);
            this.Controls.Add(this.txtVacios);
            this.Controls.Add(this.txtRestantes);
            this.Controls.Add(this.txtMaximo);
            this.Controls.Add(this.lblNumProTot);
            this.Controls.Add(this.lblProPend);
            this.Controls.Add(this.lblNumMaxPro);
            this.Controls.Add(this.lblNumVacia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdInicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdInicio;
        private System.Windows.Forms.Label lblNumProTot;
        private System.Windows.Forms.Label lblProPend;
        private System.Windows.Forms.Label lblNumMaxPro;
        private System.Windows.Forms.Label lblNumVacia;
        private System.Windows.Forms.TextBox txtMaximo;
        private System.Windows.Forms.TextBox txtRestantes;
        private System.Windows.Forms.TextBox txtVacios;
        private System.Windows.Forms.TextBox txtAtendidos;
    }
}

