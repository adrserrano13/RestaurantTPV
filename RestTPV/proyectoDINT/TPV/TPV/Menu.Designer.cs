namespace TPV
{
    partial class Menu
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.val_precio = new System.Windows.Forms.Label();
            this.val_nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUnidades = new System.Windows.Forms.Label();
            this.val_Id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // val_precio
            // 
            this.val_precio.AutoSize = true;
            this.val_precio.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val_precio.Location = new System.Drawing.Point(196, 0);
            this.val_precio.Name = "val_precio";
            this.val_precio.Size = new System.Drawing.Size(57, 23);
            this.val_precio.TabIndex = 0;
            this.val_precio.Text = "label1";
            // 
            // val_nombre
            // 
            this.val_nombre.AutoSize = true;
            this.val_nombre.Font = new System.Drawing.Font("Palatino Linotype", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val_nombre.Location = new System.Drawing.Point(20, 0);
            this.val_nombre.Name = "val_nombre";
            this.val_nombre.Size = new System.Drawing.Size(85, 20);
            this.val_nombre.TabIndex = 1;
            this.val_nombre.Text = "val_nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelUnidades
            // 
            this.labelUnidades.AutoSize = true;
            this.labelUnidades.Location = new System.Drawing.Point(297, 5);
            this.labelUnidades.Name = "labelUnidades";
            this.labelUnidades.Size = new System.Drawing.Size(16, 17);
            this.labelUnidades.TabIndex = 4;
            this.labelUnidades.Text = "1";
            // 
            // val_Id
            // 
            this.val_Id.AutoSize = true;
            this.val_Id.Location = new System.Drawing.Point(135, 21);
            this.val_Id.Name = "val_Id";
            this.val_Id.Size = new System.Drawing.Size(46, 17);
            this.val_Id.TabIndex = 5;
            this.val_Id.Text = "label2";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.val_Id);
            this.Controls.Add(this.labelUnidades);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.val_nombre);
            this.Controls.Add(this.val_precio);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(358, 41);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label val_precio;
        private System.Windows.Forms.Label val_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUnidades;
        private System.Windows.Forms.Label val_Id;
    }
}
