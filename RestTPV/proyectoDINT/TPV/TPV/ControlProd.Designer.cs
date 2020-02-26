namespace TPV
{
    partial class ControlProd
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nombre_val = new System.Windows.Forms.Label();
            this.precio_val = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 255);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nombre_val
            // 
            this.nombre_val.AutoSize = true;
            this.nombre_val.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_val.Location = new System.Drawing.Point(18, 256);
            this.nombre_val.Name = "nombre_val";
            this.nombre_val.Size = new System.Drawing.Size(63, 25);
            this.nombre_val.TabIndex = 1;
            this.nombre_val.Text = "label1";
            // 
            // precio_val
            // 
            this.precio_val.AutoSize = true;
            this.precio_val.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio_val.Location = new System.Drawing.Point(173, 258);
            this.precio_val.Name = "precio_val";
            this.precio_val.Size = new System.Drawing.Size(57, 23);
            this.precio_val.TabIndex = 2;
            this.precio_val.Text = "label2";
            // 
            // ControlProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.precio_val);
            this.Controls.Add(this.nombre_val);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ControlProd";
            this.Size = new System.Drawing.Size(251, 284);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nombre_val;
        private System.Windows.Forms.Label precio_val;
    }
}
