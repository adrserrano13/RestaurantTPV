namespace TPV
{
    partial class FormSalones
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonTerraza = new System.Windows.Forms.Button();
            this.butonSalon = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.GestionProd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BotonCerrarSesion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.buttonTerraza);
            this.panel1.Controls.Add(this.butonSalon);
            this.panel1.Location = new System.Drawing.Point(472, 246);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 375);
            this.panel1.TabIndex = 3;
            // 
            // buttonTerraza
            // 
            this.buttonTerraza.Location = new System.Drawing.Point(117, 241);
            this.buttonTerraza.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTerraza.Name = "buttonTerraza";
            this.buttonTerraza.Size = new System.Drawing.Size(629, 84);
            this.buttonTerraza.TabIndex = 1;
            this.buttonTerraza.Text = "TERRAZA";
            this.buttonTerraza.UseVisualStyleBackColor = true;
            this.buttonTerraza.Click += new System.EventHandler(this.buttonTerraza_Click);
            // 
            // butonSalon
            // 
            this.butonSalon.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butonSalon.Location = new System.Drawing.Point(117, 44);
            this.butonSalon.Margin = new System.Windows.Forms.Padding(4);
            this.butonSalon.Name = "butonSalon";
            this.butonSalon.Size = new System.Drawing.Size(629, 84);
            this.butonSalon.TabIndex = 0;
            this.butonSalon.Text = "SALÓN";
            this.butonSalon.UseVisualStyleBackColor = true;
            this.butonSalon.Click += new System.EventHandler(this.butonSalon_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::TPV.Properties.Resources.usuario__1_;
            this.pictureBox3.Location = new System.Drawing.Point(68, 41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(91, 83);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // GestionProd
            // 
            this.GestionProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GestionProd.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GestionProd.Location = new System.Drawing.Point(1610, 12);
            this.GestionProd.Name = "GestionProd";
            this.GestionProd.Size = new System.Drawing.Size(125, 57);
            this.GestionProd.TabIndex = 5;
            this.GestionProd.Text = "Gestión productos";
            this.GestionProd.UseVisualStyleBackColor = true;
            this.GestionProd.Click += new System.EventHandler(this.AgregarProductos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TPV.Properties.Resources.caja_registradora__1_1;
            this.pictureBox1.Location = new System.Drawing.Point(275, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BotonCerrarSesion
            // 
            this.BotonCerrarSesion.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCerrarSesion.Location = new System.Drawing.Point(54, 41);
            this.BotonCerrarSesion.Name = "BotonCerrarSesion";
            this.BotonCerrarSesion.Size = new System.Drawing.Size(105, 66);
            this.BotonCerrarSesion.TabIndex = 7;
            this.BotonCerrarSesion.Text = "Cerrar sesión";
            this.BotonCerrarSesion.UseVisualStyleBackColor = true;
            this.BotonCerrarSesion.Click += new System.EventHandler(this.BotonCerrarSesion_Click);
            // 
            // FormSalones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TPV.Properties.Resources.madera_nogal_clasico_wood_wallpaper__3__674297_800;
            this.ClientSize = new System.Drawing.Size(1816, 775);
            this.Controls.Add(this.BotonCerrarSesion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GestionProd);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSalones";
            this.Text = "DINEVO";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSalones_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonTerraza;
        private System.Windows.Forms.Button butonSalon;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button GestionProd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BotonCerrarSesion;
    }
}