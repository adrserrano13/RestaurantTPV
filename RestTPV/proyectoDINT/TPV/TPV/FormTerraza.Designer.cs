namespace TPV
{
    partial class FormTerraza
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LayoutMesas = new System.Windows.Forms.FlowLayoutPanel();
            this.BotonSalon = new System.Windows.Forms.Button();
            this.botonAñadir = new System.Windows.Forms.Button();
            this.BotonMenos = new System.Windows.Forms.Button();
            this.BotonMas = new System.Windows.Forms.Button();
            this.BotonActualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LayoutMesas
            // 
            this.LayoutMesas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LayoutMesas.AutoScroll = true;
            this.LayoutMesas.Location = new System.Drawing.Point(489, 399);
            this.LayoutMesas.Name = "LayoutMesas";
            this.LayoutMesas.Size = new System.Drawing.Size(201, 127);
            this.LayoutMesas.TabIndex = 17;
            // 
            // BotonSalon
            // 
            this.BotonSalon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonSalon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonSalon.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonSalon.Location = new System.Drawing.Point(1016, 507);
            this.BotonSalon.Name = "BotonSalon";
            this.BotonSalon.Size = new System.Drawing.Size(148, 70);
            this.BotonSalon.TabIndex = 16;
            this.BotonSalon.Text = "IR A SALON";
            this.BotonSalon.UseVisualStyleBackColor = true;
            this.BotonSalon.Click += new System.EventHandler(this.BotonSalon_Click);
            // 
            // botonAñadir
            // 
            this.botonAñadir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.botonAñadir.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAñadir.Location = new System.Drawing.Point(514, 220);
            this.botonAñadir.Name = "botonAñadir";
            this.botonAñadir.Size = new System.Drawing.Size(146, 45);
            this.botonAñadir.TabIndex = 15;
            this.botonAñadir.Text = "AÑADIR MESAS";
            this.botonAñadir.UseVisualStyleBackColor = true;
            this.botonAñadir.Click += new System.EventHandler(this.botonAñadir_Click);
            // 
            // BotonMenos
            // 
            this.BotonMenos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonMenos.Location = new System.Drawing.Point(1111, 38);
            this.BotonMenos.Name = "BotonMenos";
            this.BotonMenos.Size = new System.Drawing.Size(39, 29);
            this.BotonMenos.TabIndex = 14;
            this.BotonMenos.Text = "-";
            this.BotonMenos.UseVisualStyleBackColor = true;
            this.BotonMenos.Click += new System.EventHandler(this.BotonMenos_Click);
            // 
            // BotonMas
            // 
            this.BotonMas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonMas.Location = new System.Drawing.Point(1050, 38);
            this.BotonMas.Name = "BotonMas";
            this.BotonMas.Size = new System.Drawing.Size(39, 29);
            this.BotonMas.TabIndex = 13;
            this.BotonMas.Text = "+";
            this.BotonMas.UseVisualStyleBackColor = true;
            this.BotonMas.Click += new System.EventHandler(this.BotonMas_Click);
            // 
            // BotonActualizar
            // 
            this.BotonActualizar.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonActualizar.Location = new System.Drawing.Point(26, 38);
            this.BotonActualizar.Name = "BotonActualizar";
            this.BotonActualizar.Size = new System.Drawing.Size(176, 37);
            this.BotonActualizar.TabIndex = 12;
            this.BotonActualizar.Text = "ACTUALIZAR MESAS";
            this.BotonActualizar.UseVisualStyleBackColor = true;
            this.BotonActualizar.Click += new System.EventHandler(this.BotonActualizar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(384, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 106);
            this.label1.TabIndex = 11;
            this.label1.Text = "TERRAZA";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::TPV.Properties.Resources.DelanteTRANS___copia1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(2, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 95);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTerraza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TPV.Properties.Resources.fondo2;
            this.ClientSize = new System.Drawing.Size(1176, 602);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LayoutMesas);
            this.Controls.Add(this.BotonSalon);
            this.Controls.Add(this.botonAñadir);
            this.Controls.Add(this.BotonMenos);
            this.Controls.Add(this.BotonMas);
            this.Controls.Add(this.BotonActualizar);
            this.Controls.Add(this.label1);
            this.Name = "FormTerraza";
            this.Text = "DINEVO";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTerraza_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel LayoutMesas;
        private System.Windows.Forms.Button BotonSalon;
        private System.Windows.Forms.Button botonAñadir;
        private System.Windows.Forms.Button BotonMenos;
        private System.Windows.Forms.Button BotonMas;
        private System.Windows.Forms.Button BotonActualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}