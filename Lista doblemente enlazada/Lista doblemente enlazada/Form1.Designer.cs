namespace Lista_doblemente_enlazada
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
            this.cmdEliminarUltimo = new System.Windows.Forms.Button();
            this.cmdEliminarPrimero = new System.Windows.Forms.Button();
            this.cmdAgregarInicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdListarProd
            // 
            this.cmdListarProd.Location = new System.Drawing.Point(319, 180);
            this.cmdListarProd.Name = "cmdListarProd";
            this.cmdListarProd.Size = new System.Drawing.Size(102, 23);
            this.cmdListarProd.TabIndex = 44;
            this.cmdListarProd.Text = "Ver Productos";
            this.cmdListarProd.UseVisualStyleBackColor = true;
            this.cmdListarProd.Click += new System.EventHandler(this.cmdListarProd_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.Location = new System.Drawing.Point(319, 15);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfo.Size = new System.Drawing.Size(275, 150);
            this.txtInfo.TabIndex = 43;
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(102, 145);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(75, 23);
            this.cmdAgregar.TabIndex = 42;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(183, 145);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(75, 23);
            this.cmdEliminar.TabIndex = 41;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(18, 145);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(75, 23);
            this.cmdBuscar.TabIndex = 40;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(99, 89);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 39;
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(99, 63);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(100, 20);
            this.txtCant.TabIndex = 38;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(99, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 37;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(99, 11);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 36;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(12, 88);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(59, 23);
            this.lblCost.TabIndex = 35;
            this.lblCost.Text = "Costo:";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCant.Location = new System.Drawing.Point(12, 65);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(76, 23);
            this.lblCant.TabIndex = 34;
            this.lblCant.Text = "Cantidad";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 23);
            this.lblNombre.TabIndex = 33;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(12, 13);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(65, 23);
            this.lblCodigo.TabIndex = 32;
            this.lblCodigo.Text = "Código:";
            // 
            // cmdEliminarUltimo
            // 
            this.cmdEliminarUltimo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdEliminarUltimo.Location = new System.Drawing.Point(205, 192);
            this.cmdEliminarUltimo.Name = "cmdEliminarUltimo";
            this.cmdEliminarUltimo.Size = new System.Drawing.Size(100, 23);
            this.cmdEliminarUltimo.TabIndex = 47;
            this.cmdEliminarUltimo.Text = "Eliminar Ultimo";
            this.cmdEliminarUltimo.UseVisualStyleBackColor = true;
            this.cmdEliminarUltimo.Click += new System.EventHandler(this.cmdEliminarUltimo_Click);
            // 
            // cmdEliminarPrimero
            // 
            this.cmdEliminarPrimero.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdEliminarPrimero.Location = new System.Drawing.Point(99, 192);
            this.cmdEliminarPrimero.Name = "cmdEliminarPrimero";
            this.cmdEliminarPrimero.Size = new System.Drawing.Size(100, 23);
            this.cmdEliminarPrimero.TabIndex = 46;
            this.cmdEliminarPrimero.Text = "Eliminar Primero";
            this.cmdEliminarPrimero.UseVisualStyleBackColor = true;
            this.cmdEliminarPrimero.Click += new System.EventHandler(this.cmdEliminarPrimero_Click);
            // 
            // cmdAgregarInicio
            // 
            this.cmdAgregarInicio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAgregarInicio.Location = new System.Drawing.Point(12, 192);
            this.cmdAgregarInicio.Name = "cmdAgregarInicio";
            this.cmdAgregarInicio.Size = new System.Drawing.Size(88, 23);
            this.cmdAgregarInicio.TabIndex = 45;
            this.cmdAgregarInicio.Text = "Agregar Inicio";
            this.cmdAgregarInicio.UseVisualStyleBackColor = true;
            this.cmdAgregarInicio.Click += new System.EventHandler(this.cmdAgregarInicio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 252);
            this.Controls.Add(this.cmdEliminarUltimo);
            this.Controls.Add(this.cmdEliminarPrimero);
            this.Controls.Add(this.cmdAgregarInicio);
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
            this.Text = "Form1";
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
        private System.Windows.Forms.Button cmdEliminarUltimo;
        private System.Windows.Forms.Button cmdEliminarPrimero;
        private System.Windows.Forms.Button cmdAgregarInicio;
    }
}

