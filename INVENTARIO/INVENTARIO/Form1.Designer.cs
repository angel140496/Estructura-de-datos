namespace INVENTARIO
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
            this.cmdListarProd = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtposicion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdListarProd
            // 
            this.cmdListarProd.Location = new System.Drawing.Point(287, 216);
            this.cmdListarProd.Name = "cmdListarProd";
            this.cmdListarProd.Size = new System.Drawing.Size(102, 23);
            this.cmdListarProd.TabIndex = 44;
            this.cmdListarProd.Text = "Ver Productos";
            this.cmdListarProd.UseVisualStyleBackColor = true;
            this.cmdListarProd.Click += new System.EventHandler(this.cmdListarProd_Click_1);
            // 
            // txtInfo
            // 
            this.txtInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.Location = new System.Drawing.Point(287, 51);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfo.Size = new System.Drawing.Size(275, 150);
            this.txtInfo.TabIndex = 43;
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(92, 157);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(75, 23);
            this.cmdAgregar.TabIndex = 42;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click_1);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(173, 157);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(75, 23);
            this.cmdEliminar.TabIndex = 41;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click_1);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(8, 157);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(75, 23);
            this.cmdBuscar.TabIndex = 40;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(89, 101);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 39;
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(89, 75);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(100, 20);
            this.txtCant.TabIndex = 38;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(89, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 37;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(89, 23);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 36;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(2, 100);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(59, 23);
            this.lblCost.TabIndex = 35;
            this.lblCost.Text = "Costo:";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCant.Location = new System.Drawing.Point(2, 77);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(76, 23);
            this.lblCant.TabIndex = 34;
            this.lblCant.Text = "Cantidad";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(2, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 23);
            this.lblNombre.TabIndex = 33;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(2, 25);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(65, 23);
            this.lblCodigo.TabIndex = 32;
            this.lblCodigo.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 45;
            this.label1.Text = "Posicion:";
            // 
            // txtposicion
            // 
            this.txtposicion.Location = new System.Drawing.Point(89, 128);
            this.txtposicion.Name = "txtposicion";
            this.txtposicion.Size = new System.Drawing.Size(100, 20);
            this.txtposicion.TabIndex = 46;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(571, 252);
            this.Controls.Add(this.txtposicion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdListarProd);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Name = "Form1";
            this.Text = "INVENTARIO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdListarProd;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtposicion;
    }
}

