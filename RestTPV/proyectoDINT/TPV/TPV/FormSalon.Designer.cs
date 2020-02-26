namespace TPV
{
    partial class FormSalon
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
            this.label1 = new System.Windows.Forms.Label();
            this.BotonActualizar = new System.Windows.Forms.Button();
            this.LayoutMesas = new System.Windows.Forms.FlowLayoutPanel();
            this.BotonTerraza = new System.Windows.Forms.Button();
            this.BotonMenos = new System.Windows.Forms.Button();
            this.BotonMas = new System.Windows.Forms.Button();
            this.botonAñadir = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(438, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 106);
            this.label1.TabIndex = 3;
            this.label1.Text = "SALÓN";
            // 
            // BotonActualizar
            // 
            this.BotonActualizar.BackColor = System.Drawing.SystemColors.Control;
            this.BotonActualizar.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonActualizar.Location = new System.Drawing.Point(43, 32);
            this.BotonActualizar.Name = "BotonActualizar";
            this.BotonActualizar.Size = new System.Drawing.Size(176, 37);
            this.BotonActualizar.TabIndex = 4;
            this.BotonActualizar.Text = "ACTUALIZAR MESAS";
            this.BotonActualizar.UseVisualStyleBackColor = false;
            this.BotonActualizar.Click += new System.EventHandler(this.BotonActualizar_Click);
            // 
            // LayoutMesas
            // 
            this.LayoutMesas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LayoutMesas.AutoScroll = true;
            this.LayoutMesas.Location = new System.Drawing.Point(499, 337);
            this.LayoutMesas.Name = "LayoutMesas";
            this.LayoutMesas.Size = new System.Drawing.Size(232, 142);
            this.LayoutMesas.TabIndex = 10;
            // 
            // BotonTerraza
            // 
            this.BotonTerraza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonTerraza.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BotonTerraza.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonTerraza.Location = new System.Drawing.Point(977, 463);
            this.BotonTerraza.Name = "BotonTerraza";
            this.BotonTerraza.Size = new System.Drawing.Size(148, 65);
            this.BotonTerraza.TabIndex = 9;
            this.BotonTerraza.Text = "IR A TERRAZA";
            this.BotonTerraza.UseVisualStyleBackColor = true;
            this.BotonTerraza.Click += new System.EventHandler(this.BotonTerraza_Click_1);
            // 
            // BotonMenos
            // 
            this.BotonMenos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonMenos.Location = new System.Drawing.Point(1086, 22);
            this.BotonMenos.Name = "BotonMenos";
            this.BotonMenos.Size = new System.Drawing.Size(39, 29);
            this.BotonMenos.TabIndex = 12;
            this.BotonMenos.Text = "-";
            this.BotonMenos.UseVisualStyleBackColor = true;
            this.BotonMenos.Click += new System.EventHandler(this.BotonMenos_Click);
            // 
            // BotonMas
            // 
            this.BotonMas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonMas.Location = new System.Drawing.Point(1030, 22);
            this.BotonMas.Name = "BotonMas";
            this.BotonMas.Size = new System.Drawing.Size(39, 29);
            this.BotonMas.TabIndex = 11;
            this.BotonMas.Text = "+";
            this.BotonMas.UseVisualStyleBackColor = true;
            this.BotonMas.Click += new System.EventHandler(this.BotonMas_Click_1);
            // 
            // botonAñadir
            // 
            this.botonAñadir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.botonAñadir.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAñadir.Location = new System.Drawing.Point(534, 196);
            this.botonAñadir.Name = "botonAñadir";
            this.botonAñadir.Size = new System.Drawing.Size(146, 45);
            this.botonAñadir.TabIndex = 8;
            this.botonAñadir.Text = "AÑADIR MESAS";
            this.botonAñadir.UseVisualStyleBackColor = true;
            this.botonAñadir.Click += new System.EventHandler(this.botonAñadir_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.BackgroundImage = global::TPV.Properties.Resources.DelanteTRANS___copia;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Location = new System.Drawing.Point(12, 418);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(117, 110);
            this.btnAtras.TabIndex = 13;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // FormSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TPV.Properties.Resources.madera_nogal_clasico_wood_wallpaper__3__674297_800;
            this.ClientSize = new System.Drawing.Size(1137, 540);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.BotonMenos);
            this.Controls.Add(this.BotonMas);
            this.Controls.Add(this.LayoutMesas);
            this.Controls.Add(this.BotonTerraza);
            this.Controls.Add(this.botonAñadir);
            this.Controls.Add(this.BotonActualizar);
            this.Controls.Add(this.label1);
            this.Name = "FormSalon";
            this.Text = "DINEVO";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSalon_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonActualizar;
        private System.Windows.Forms.FlowLayoutPanel LayoutMesas;
        private System.Windows.Forms.Button BotonTerraza;
        private System.Windows.Forms.Button botonAñadir;
        private System.Windows.Forms.Button BotonMenos;
        private System.Windows.Forms.Button BotonMas;
        private System.Windows.Forms.Button btnAtras;
    }
}