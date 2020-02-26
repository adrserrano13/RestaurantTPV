namespace TPV
{
    partial class FormMesaTerr
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnCobrarTarjeta = new System.Windows.Forms.Button();
            this.BotonCobrar = new System.Windows.Forms.Button();
            this.BotonMarchar = new System.Windows.Forms.Button();
            this.BotonImprimir = new System.Windows.Forms.Button();
            this.val_total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.BtonBebidas = new System.Windows.Forms.Button();
            this.BtonPostres = new System.Windows.Forms.Button();
            this.BtnPlatos = new System.Windows.Forms.Button();
            this.BtnBocadillos = new System.Windows.Forms.Button();
            this.BtnCafe = new System.Windows.Forms.Button();
            this.BtnApreritivos = new System.Windows.Forms.Button();
            this.LabelMesa = new System.Windows.Forms.Label();
            this.botonAtras = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.OldLace;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.BtnCobrarTarjeta);
            this.panel4.Controls.Add(this.BotonCobrar);
            this.panel4.Controls.Add(this.BotonMarchar);
            this.panel4.Controls.Add(this.BotonImprimir);
            this.panel4.Controls.Add(this.val_total);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(21, 709);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(381, 242);
            this.panel4.TabIndex = 14;
            // 
            // BtnCobrarTarjeta
            // 
            this.BtnCobrarTarjeta.BackgroundImage = global::TPV.Properties.Resources.tarjeta_de_credito;
            this.BtnCobrarTarjeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCobrarTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCobrarTarjeta.Location = new System.Drawing.Point(271, 140);
            this.BtnCobrarTarjeta.Name = "BtnCobrarTarjeta";
            this.BtnCobrarTarjeta.Size = new System.Drawing.Size(87, 68);
            this.BtnCobrarTarjeta.TabIndex = 14;
            this.BtnCobrarTarjeta.UseVisualStyleBackColor = true;
            this.BtnCobrarTarjeta.Click += new System.EventHandler(this.BtnCobrarTarjeta_Click);
            // 
            // BotonCobrar
            // 
            this.BotonCobrar.BackgroundImage = global::TPV.Properties.Resources.dinero__1_1;
            this.BotonCobrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCobrar.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCobrar.Location = new System.Drawing.Point(24, 140);
            this.BotonCobrar.Name = "BotonCobrar";
            this.BotonCobrar.Size = new System.Drawing.Size(86, 68);
            this.BotonCobrar.TabIndex = 11;
            this.BotonCobrar.UseVisualStyleBackColor = true;
            this.BotonCobrar.Click += new System.EventHandler(this.BotonCobrar_Click);
            // 
            // BotonMarchar
            // 
            this.BotonMarchar.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonMarchar.Location = new System.Drawing.Point(148, 140);
            this.BotonMarchar.Name = "BotonMarchar";
            this.BotonMarchar.Size = new System.Drawing.Size(82, 68);
            this.BotonMarchar.TabIndex = 10;
            this.BotonMarchar.Text = "Ir a terraza";
            this.BotonMarchar.UseVisualStyleBackColor = true;
            this.BotonMarchar.Click += new System.EventHandler(this.BotonMarchar_Click);
            // 
            // BotonImprimir
            // 
            this.BotonImprimir.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonImprimir.Location = new System.Drawing.Point(24, 59);
            this.BotonImprimir.Name = "BotonImprimir";
            this.BotonImprimir.Size = new System.Drawing.Size(334, 48);
            this.BotonImprimir.TabIndex = 12;
            this.BotonImprimir.Text = "Imprimir";
            this.BotonImprimir.UseVisualStyleBackColor = true;
            // 
            // val_total
            // 
            this.val_total.AutoSize = true;
            this.val_total.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val_total.Location = new System.Drawing.Point(228, 0);
            this.val_total.Name = "val_total";
            this.val_total.Size = new System.Drawing.Size(22, 27);
            this.val_total.TabIndex = 13;
            this.val_total.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL:";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.OldLace;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(21, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(381, 649);
            this.panel3.TabIndex = 13;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.OldLace;
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel2.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel2.Location = new System.Drawing.Point(429, 288);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1409, 663);
            this.Panel2.TabIndex = 12;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.OldLace;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.BtonBebidas);
            this.Panel1.Controls.Add(this.BtonPostres);
            this.Panel1.Controls.Add(this.BtnPlatos);
            this.Panel1.Controls.Add(this.BtnBocadillos);
            this.Panel1.Controls.Add(this.BtnCafe);
            this.Panel1.Controls.Add(this.BtnApreritivos);
            this.Panel1.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel1.Location = new System.Drawing.Point(429, 54);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1409, 219);
            this.Panel1.TabIndex = 11;
            // 
            // BtonBebidas
            // 
            this.BtonBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtonBebidas.Location = new System.Drawing.Point(54, 58);
            this.BtonBebidas.Name = "BtonBebidas";
            this.BtonBebidas.Size = new System.Drawing.Size(151, 93);
            this.BtonBebidas.TabIndex = 1;
            this.BtonBebidas.Text = "BEBIDAD";
            this.BtonBebidas.UseVisualStyleBackColor = true;
            this.BtonBebidas.Click += new System.EventHandler(this.BtonBebidas_Click);
            // 
            // BtonPostres
            // 
            this.BtonPostres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtonPostres.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtonPostres.Location = new System.Drawing.Point(1201, 58);
            this.BtonPostres.Name = "BtonPostres";
            this.BtonPostres.Size = new System.Drawing.Size(151, 93);
            this.BtonPostres.TabIndex = 6;
            this.BtonPostres.Text = "POSTRES";
            this.BtonPostres.UseVisualStyleBackColor = true;
            this.BtonPostres.Click += new System.EventHandler(this.BtonPostres_Click);
            // 
            // BtnPlatos
            // 
            this.BtnPlatos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnPlatos.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlatos.Location = new System.Drawing.Point(751, 59);
            this.BtnPlatos.Name = "BtnPlatos";
            this.BtnPlatos.Size = new System.Drawing.Size(151, 93);
            this.BtnPlatos.TabIndex = 5;
            this.BtnPlatos.Text = "PLATOS";
            this.BtnPlatos.UseVisualStyleBackColor = true;
            this.BtnPlatos.Click += new System.EventHandler(this.BtnPlatos_Click);
            // 
            // BtnBocadillos
            // 
            this.BtnBocadillos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnBocadillos.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBocadillos.Location = new System.Drawing.Point(512, 61);
            this.BtnBocadillos.Name = "BtnBocadillos";
            this.BtnBocadillos.Size = new System.Drawing.Size(151, 91);
            this.BtnBocadillos.TabIndex = 3;
            this.BtnBocadillos.Text = "BOCADILLOS";
            this.BtnBocadillos.UseVisualStyleBackColor = true;
            this.BtnBocadillos.Click += new System.EventHandler(this.BtnBocadillos_Click);
            // 
            // BtnCafe
            // 
            this.BtnCafe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnCafe.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCafe.Location = new System.Drawing.Point(986, 58);
            this.BtnCafe.Name = "BtnCafe";
            this.BtnCafe.Size = new System.Drawing.Size(151, 93);
            this.BtnCafe.TabIndex = 4;
            this.BtnCafe.Text = "CAFE";
            this.BtnCafe.UseVisualStyleBackColor = true;
            this.BtnCafe.Click += new System.EventHandler(this.BtnCafe_Click);
            // 
            // BtnApreritivos
            // 
            this.BtnApreritivos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnApreritivos.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApreritivos.Location = new System.Drawing.Point(281, 59);
            this.BtnApreritivos.Name = "BtnApreritivos";
            this.BtnApreritivos.Size = new System.Drawing.Size(151, 93);
            this.BtnApreritivos.TabIndex = 2;
            this.BtnApreritivos.Text = "APERITIVOS";
            this.BtnApreritivos.UseVisualStyleBackColor = true;
            this.BtnApreritivos.Click += new System.EventHandler(this.BtnApreritivos_Click);
            // 
            // LabelMesa
            // 
            this.LabelMesa.AutoSize = true;
            this.LabelMesa.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMesa.Location = new System.Drawing.Point(165, 9);
            this.LabelMesa.Name = "LabelMesa";
            this.LabelMesa.Size = new System.Drawing.Size(78, 32);
            this.LabelMesa.TabIndex = 15;
            this.LabelMesa.Text = "label1";
            this.LabelMesa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botonAtras
            // 
            this.botonAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonAtras.BackColor = System.Drawing.Color.Transparent;
            this.botonAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.botonAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.botonAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAtras.Image = global::TPV.Properties.Resources.DelanteTRANS___copia;
            this.botonAtras.Location = new System.Drawing.Point(1811, 9);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(101, 82);
            this.botonAtras.TabIndex = 16;
            this.botonAtras.UseVisualStyleBackColor = false;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // FormMesaTerr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TPV.Properties.Resources.fondo2;
            this.ClientSize = new System.Drawing.Size(1924, 963);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.LabelMesa);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Name = "FormMesaTerr";
            this.Text = "FormMesaTerr";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMesaTerr_FormClosed);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnCobrarTarjeta;
        private System.Windows.Forms.Button BotonCobrar;
        private System.Windows.Forms.Button BotonMarchar;
        private System.Windows.Forms.Button BotonImprimir;
        private System.Windows.Forms.Label val_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel panel3;
        private System.Windows.Forms.FlowLayoutPanel Panel2;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Button BtonBebidas;
        private System.Windows.Forms.Button BtonPostres;
        private System.Windows.Forms.Button BtnPlatos;
        private System.Windows.Forms.Button BtnBocadillos;
        private System.Windows.Forms.Button BtnCafe;
        private System.Windows.Forms.Button BtnApreritivos;
        private System.Windows.Forms.Label LabelMesa;
        private System.Windows.Forms.Button botonAtras;
    }
}