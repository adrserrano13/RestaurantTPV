namespace TPV
{
    partial class FormArqueo
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
            this.botonArqueo = new System.Windows.Forms.Button();
            this.botonAbriCaja = new System.Windows.Forms.Button();
            this.botonCerrarCaja = new System.Windows.Forms.Button();
            this.labelCambio = new System.Windows.Forms.Label();
            this.labelEfectivo = new System.Windows.Forms.Label();
            this.labelTarjeta = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.val_cambio = new System.Windows.Forms.TextBox();
            this.val_efectivo = new System.Windows.Forms.TextBox();
            this.val_tarjeta = new System.Windows.Forms.TextBox();
            this.val_total = new System.Windows.Forms.TextBox();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.labelTotalEfectivo = new System.Windows.Forms.Label();
            this.val_totalEfectivo = new System.Windows.Forms.TextBox();
            this.botonAcepatr2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonArqueo
            // 
            this.botonArqueo.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonArqueo.Location = new System.Drawing.Point(354, 12);
            this.botonArqueo.Name = "botonArqueo";
            this.botonArqueo.Size = new System.Drawing.Size(111, 73);
            this.botonArqueo.TabIndex = 0;
            this.botonArqueo.Text = "Arqueo";
            this.botonArqueo.UseVisualStyleBackColor = true;
            this.botonArqueo.Click += new System.EventHandler(this.button1_Click);
            // 
            // botonAbriCaja
            // 
            this.botonAbriCaja.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAbriCaja.Location = new System.Drawing.Point(122, 12);
            this.botonAbriCaja.Name = "botonAbriCaja";
            this.botonAbriCaja.Size = new System.Drawing.Size(111, 73);
            this.botonAbriCaja.TabIndex = 1;
            this.botonAbriCaja.Text = "Abrir caja";
            this.botonAbriCaja.UseVisualStyleBackColor = true;
            this.botonAbriCaja.Click += new System.EventHandler(this.botonAbriCaja_Click);
            // 
            // botonCerrarCaja
            // 
            this.botonCerrarCaja.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCerrarCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonCerrarCaja.Location = new System.Drawing.Point(122, 12);
            this.botonCerrarCaja.Name = "botonCerrarCaja";
            this.botonCerrarCaja.Size = new System.Drawing.Size(111, 73);
            this.botonCerrarCaja.TabIndex = 2;
            this.botonCerrarCaja.Text = "Cerrar caja";
            this.botonCerrarCaja.UseVisualStyleBackColor = true;
            this.botonCerrarCaja.Click += new System.EventHandler(this.botonCerrarCaja_Click);
            // 
            // labelCambio
            // 
            this.labelCambio.AutoSize = true;
            this.labelCambio.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCambio.Location = new System.Drawing.Point(12, 152);
            this.labelCambio.Name = "labelCambio";
            this.labelCambio.Size = new System.Drawing.Size(281, 23);
            this.labelCambio.TabIndex = 3;
            this.labelCambio.Text = "Introduce el cambio que hay en caja:";
            // 
            // labelEfectivo
            // 
            this.labelEfectivo.AutoSize = true;
            this.labelEfectivo.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEfectivo.Location = new System.Drawing.Point(96, 218);
            this.labelEfectivo.Name = "labelEfectivo";
            this.labelEfectivo.Size = new System.Drawing.Size(197, 23);
            this.labelEfectivo.TabIndex = 4;
            this.labelEfectivo.Text = "Total efectivo facturado:";
            // 
            // labelTarjeta
            // 
            this.labelTarjeta.AutoSize = true;
            this.labelTarjeta.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarjeta.Location = new System.Drawing.Point(104, 278);
            this.labelTarjeta.Name = "labelTarjeta";
            this.labelTarjeta.Size = new System.Drawing.Size(189, 23);
            this.labelTarjeta.TabIndex = 5;
            this.labelTarjeta.Text = "Total tarjeta facturado:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(65, 411);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(156, 27);
            this.labelTotal.TabIndex = 6;
            this.labelTotal.Text = "Total facturado:";
            // 
            // val_cambio
            // 
            this.val_cambio.Location = new System.Drawing.Point(340, 153);
            this.val_cambio.Name = "val_cambio";
            this.val_cambio.Size = new System.Drawing.Size(58, 22);
            this.val_cambio.TabIndex = 7;
            // 
            // val_efectivo
            // 
            this.val_efectivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.val_efectivo.Location = new System.Drawing.Point(340, 218);
            this.val_efectivo.Name = "val_efectivo";
            this.val_efectivo.ReadOnly = true;
            this.val_efectivo.Size = new System.Drawing.Size(58, 22);
            this.val_efectivo.TabIndex = 8;
            // 
            // val_tarjeta
            // 
            this.val_tarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.val_tarjeta.Location = new System.Drawing.Point(340, 280);
            this.val_tarjeta.Name = "val_tarjeta";
            this.val_tarjeta.ReadOnly = true;
            this.val_tarjeta.Size = new System.Drawing.Size(58, 22);
            this.val_tarjeta.TabIndex = 9;
            // 
            // val_total
            // 
            this.val_total.Location = new System.Drawing.Point(247, 416);
            this.val_total.Name = "val_total";
            this.val_total.ReadOnly = true;
            this.val_total.Size = new System.Drawing.Size(58, 22);
            this.val_total.TabIndex = 10;
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(473, 407);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(88, 41);
            this.botonAceptar.TabIndex = 11;
            this.botonAceptar.Text = "OK";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // labelTotalEfectivo
            // 
            this.labelTotalEfectivo.AutoSize = true;
            this.labelTotalEfectivo.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalEfectivo.Location = new System.Drawing.Point(15, 359);
            this.labelTotalEfectivo.Name = "labelTotalEfectivo";
            this.labelTotalEfectivo.Size = new System.Drawing.Size(206, 27);
            this.labelTotalEfectivo.TabIndex = 12;
            this.labelTotalEfectivo.Text = "Total efectivo en caja:";
            // 
            // val_totalEfectivo
            // 
            this.val_totalEfectivo.Location = new System.Drawing.Point(247, 363);
            this.val_totalEfectivo.Name = "val_totalEfectivo";
            this.val_totalEfectivo.ReadOnly = true;
            this.val_totalEfectivo.Size = new System.Drawing.Size(58, 22);
            this.val_totalEfectivo.TabIndex = 13;
            // 
            // botonAcepatr2
            // 
            this.botonAcepatr2.Location = new System.Drawing.Point(462, 407);
            this.botonAcepatr2.Name = "botonAcepatr2";
            this.botonAcepatr2.Size = new System.Drawing.Size(88, 41);
            this.botonAcepatr2.TabIndex = 14;
            this.botonAcepatr2.Text = "OK";
            this.botonAcepatr2.UseVisualStyleBackColor = true;
            this.botonAcepatr2.Click += new System.EventHandler(this.botonAcepatr2_Click);
            // 
            // FormArqueo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TPV.Properties.Resources.findo4;
            this.ClientSize = new System.Drawing.Size(573, 447);
            this.Controls.Add(this.botonAcepatr2);
            this.Controls.Add(this.val_totalEfectivo);
            this.Controls.Add(this.labelTotalEfectivo);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.val_total);
            this.Controls.Add(this.val_tarjeta);
            this.Controls.Add(this.val_efectivo);
            this.Controls.Add(this.val_cambio);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelTarjeta);
            this.Controls.Add(this.labelEfectivo);
            this.Controls.Add(this.labelCambio);
            this.Controls.Add(this.botonCerrarCaja);
            this.Controls.Add(this.botonAbriCaja);
            this.Controls.Add(this.botonArqueo);
            this.Name = "FormArqueo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormArqueo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonArqueo;
        private System.Windows.Forms.Button botonAbriCaja;
        private System.Windows.Forms.Button botonCerrarCaja;
        private System.Windows.Forms.Label labelCambio;
        private System.Windows.Forms.Label labelEfectivo;
        private System.Windows.Forms.Label labelTarjeta;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox val_cambio;
        private System.Windows.Forms.TextBox val_efectivo;
        private System.Windows.Forms.TextBox val_tarjeta;
        private System.Windows.Forms.TextBox val_total;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Label labelTotalEfectivo;
        private System.Windows.Forms.TextBox val_totalEfectivo;
        private System.Windows.Forms.Button botonAcepatr2;
    }
}