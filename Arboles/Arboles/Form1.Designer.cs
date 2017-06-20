namespace Arboles
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
            this.txtPostOrden = new System.Windows.Forms.TextBox();
            this.txtPreOrden = new System.Windows.Forms.TextBox();
            this.txtInOrden = new System.Windows.Forms.TextBox();
            this.lblPostOrden = new System.Windows.Forms.Label();
            this.lblPreOrden = new System.Windows.Forms.Label();
            this.lblInOrden = new System.Windows.Forms.Label();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnRes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPostOrden
            // 
            this.txtPostOrden.Location = new System.Drawing.Point(182, 238);
            this.txtPostOrden.Name = "txtPostOrden";
            this.txtPostOrden.Size = new System.Drawing.Size(250, 20);
            this.txtPostOrden.TabIndex = 25;
            // 
            // txtPreOrden
            // 
            this.txtPreOrden.Location = new System.Drawing.Point(182, 182);
            this.txtPreOrden.Name = "txtPreOrden";
            this.txtPreOrden.Size = new System.Drawing.Size(250, 20);
            this.txtPreOrden.TabIndex = 24;
            // 
            // txtInOrden
            // 
            this.txtInOrden.Location = new System.Drawing.Point(182, 129);
            this.txtInOrden.Name = "txtInOrden";
            this.txtInOrden.Size = new System.Drawing.Size(250, 20);
            this.txtInOrden.TabIndex = 23;
            // 
            // lblPostOrden
            // 
            this.lblPostOrden.AutoSize = true;
            this.lblPostOrden.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostOrden.Location = new System.Drawing.Point(-2, 238);
            this.lblPostOrden.Name = "lblPostOrden";
            this.lblPostOrden.Size = new System.Drawing.Size(195, 23);
            this.lblPostOrden.TabIndex = 22;
            this.lblPostOrden.Text = "Recorrido en PostOrden :";
            this.lblPostOrden.Click += new System.EventHandler(this.lblPostOrden_Click);
            // 
            // lblPreOrden
            // 
            this.lblPreOrden.AutoSize = true;
            this.lblPreOrden.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreOrden.Location = new System.Drawing.Point(-2, 182);
            this.lblPreOrden.Name = "lblPreOrden";
            this.lblPreOrden.Size = new System.Drawing.Size(189, 23);
            this.lblPreOrden.TabIndex = 21;
            this.lblPreOrden.Text = "Recorrido en PreOrden :";
            this.lblPreOrden.Click += new System.EventHandler(this.lblPreOrden_Click);
            // 
            // lblInOrden
            // 
            this.lblInOrden.AutoSize = true;
            this.lblInOrden.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInOrden.Location = new System.Drawing.Point(-2, 129);
            this.lblInOrden.Name = "lblInOrden";
            this.lblInOrden.Size = new System.Drawing.Size(237, 23);
            this.lblInOrden.TabIndex = 20;
            this.lblInOrden.Text = "Recorrido en InOrden :           ";
            this.lblInOrden.Click += new System.EventHandler(this.lblInOrden_Click);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAgregar.Location = new System.Drawing.Point(12, 75);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(97, 23);
            this.cmdAgregar.TabIndex = 19;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(12, 49);
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(208, 20);
            this.txtDatos.TabIndex = 18;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(12, 18);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(145, 23);
            this.lblDatos.TabIndex = 17;
            this.lblDatos.Text = "Ingresa los datos :";
            this.lblDatos.Click += new System.EventHandler(this.lblDatos_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.Location = new System.Drawing.Point(466, 126);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(133, 23);
            this.lblRes.TabIndex = 27;
            this.lblRes.Text = "Resultados         ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(454, 238);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 30;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(454, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 20);
            this.textBox2.TabIndex = 29;
            // 
            // btnRes
            // 
            this.btnRes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRes.Location = new System.Drawing.Point(145, 75);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(75, 23);
            this.btnRes.TabIndex = 31;
            this.btnRes.Text = "Resultados";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 302);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.txtPostOrden);
            this.Controls.Add(this.txtPreOrden);
            this.Controls.Add(this.txtInOrden);
            this.Controls.Add(this.lblPostOrden);
            this.Controls.Add(this.lblPreOrden);
            this.Controls.Add(this.lblInOrden);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.lblDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPostOrden;
        private System.Windows.Forms.TextBox txtPreOrden;
        private System.Windows.Forms.TextBox txtInOrden;
        private System.Windows.Forms.Label lblPostOrden;
        private System.Windows.Forms.Label lblPreOrden;
        private System.Windows.Forms.Label lblInOrden;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnRes;
    }
}

