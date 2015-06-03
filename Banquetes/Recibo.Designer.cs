namespace Banquetes
{
    partial class Recibo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recibo));
            this.lblInfoRecibo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombreComp = new System.Windows.Forms.Label();
            this.lblFechaRecibo = new System.Windows.Forms.Label();
            this.lblFolioA = new System.Windows.Forms.Label();
            this.lblFolio = new System.Windows.Forms.Label();
            this.lblFechaReciboA = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblTelCliente = new System.Windows.Forms.Label();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.lblEvento = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblHoraEvento = new System.Windows.Forms.Label();
            this.lblFechaEvento = new System.Windows.Forms.Label();
            this.lblNombreEvento = new System.Windows.Forms.Label();
            this.lblDireccionEvento = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lstvMenu = new System.Windows.Forms.ListView();
            this.colPlatillo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPorciones = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblSubtotalA = new System.Windows.Forms.Label();
            this.lblIvaA = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblSeparador = new System.Windows.Forms.Label();
            this.lblTotalA = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfoRecibo
            // 
            this.lblInfoRecibo.AutoSize = true;
            this.lblInfoRecibo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(88)))), ((int)(((byte)(70)))));
            this.lblInfoRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoRecibo.ForeColor = System.Drawing.Color.White;
            this.lblInfoRecibo.Location = new System.Drawing.Point(12, 12);
            this.lblInfoRecibo.Name = "lblInfoRecibo";
            this.lblInfoRecibo.Size = new System.Drawing.Size(61, 18);
            this.lblInfoRecibo.TabIndex = 2;
            this.lblInfoRecibo.Text = "Recibo";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 391);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 10);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblNombreComp
            // 
            this.lblNombreComp.AutoSize = true;
            this.lblNombreComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreComp.Location = new System.Drawing.Point(12, 46);
            this.lblNombreComp.Name = "lblNombreComp";
            this.lblNombreComp.Size = new System.Drawing.Size(143, 18);
            this.lblNombreComp.TabIndex = 4;
            this.lblNombreComp.Text = "Banquetes IntelliJED";
            // 
            // lblFechaRecibo
            // 
            this.lblFechaRecibo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaRecibo.AutoSize = true;
            this.lblFechaRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRecibo.Location = new System.Drawing.Point(429, 72);
            this.lblFechaRecibo.Name = "lblFechaRecibo";
            this.lblFechaRecibo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFechaRecibo.Size = new System.Drawing.Size(69, 15);
            this.lblFechaRecibo.TabIndex = 5;
            this.lblFechaRecibo.Text = "02/12/2015";
            this.lblFechaRecibo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFolioA
            // 
            this.lblFolioA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFolioA.AutoSize = true;
            this.lblFolioA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolioA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(88)))), ((int)(((byte)(70)))));
            this.lblFolioA.Location = new System.Drawing.Point(373, 47);
            this.lblFolioA.Name = "lblFolioA";
            this.lblFolioA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFolioA.Size = new System.Drawing.Size(47, 16);
            this.lblFolioA.TabIndex = 6;
            this.lblFolioA.Text = "Folio:";
            this.lblFolioA.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFolio
            // 
            this.lblFolio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.Location = new System.Drawing.Point(429, 47);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFolio.Size = new System.Drawing.Size(35, 15);
            this.lblFolio.TabIndex = 7;
            this.lblFolio.Text = "1001";
            this.lblFolio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFechaReciboA
            // 
            this.lblFechaReciboA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaReciboA.AutoSize = true;
            this.lblFechaReciboA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaReciboA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(88)))), ((int)(((byte)(70)))));
            this.lblFechaReciboA.Location = new System.Drawing.Point(365, 72);
            this.lblFechaReciboA.Name = "lblFechaReciboA";
            this.lblFechaReciboA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFechaReciboA.Size = new System.Drawing.Size(55, 16);
            this.lblFechaReciboA.TabIndex = 8;
            this.lblFechaReciboA.Text = "Fecha:";
            this.lblFechaReciboA.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(32, 391);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(43, 33);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(88)))), ((int)(((byte)(70)))));
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(12, 103);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(60, 18);
            this.lblCliente.TabIndex = 9;
            this.lblCliente.Text = "Cliente";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(12, 134);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(85, 13);
            this.lblNombreCliente.TabIndex = 11;
            this.lblNombreCliente.Text = "[Nombre Cliente]";
            // 
            // lblTelCliente
            // 
            this.lblTelCliente.AutoSize = true;
            this.lblTelCliente.Location = new System.Drawing.Point(12, 152);
            this.lblTelCliente.Name = "lblTelCliente";
            this.lblTelCliente.Size = new System.Drawing.Size(90, 13);
            this.lblTelCliente.TabIndex = 13;
            this.lblTelCliente.Text = "[Teléfono Cliente]";
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Location = new System.Drawing.Point(12, 169);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(77, 13);
            this.lblEmailCliente.TabIndex = 15;
            this.lblEmailCliente.Text = "[E-Mail Cliente]";
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(88)))), ((int)(((byte)(70)))));
            this.lblEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvento.ForeColor = System.Drawing.Color.White;
            this.lblEvento.Location = new System.Drawing.Point(277, 103);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(60, 18);
            this.lblEvento.TabIndex = 16;
            this.lblEvento.Text = "Evento";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(81, 384);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(43, 33);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lblHoraEvento
            // 
            this.lblHoraEvento.AutoSize = true;
            this.lblHoraEvento.Location = new System.Drawing.Point(277, 168);
            this.lblHoraEvento.Name = "lblHoraEvento";
            this.lblHoraEvento.Size = new System.Drawing.Size(73, 13);
            this.lblHoraEvento.TabIndex = 19;
            this.lblHoraEvento.Text = "[Hora Evento]";
            // 
            // lblFechaEvento
            // 
            this.lblFechaEvento.AutoSize = true;
            this.lblFechaEvento.Location = new System.Drawing.Point(277, 151);
            this.lblFechaEvento.Name = "lblFechaEvento";
            this.lblFechaEvento.Size = new System.Drawing.Size(78, 13);
            this.lblFechaEvento.TabIndex = 18;
            this.lblFechaEvento.Text = "[Fecha Cliente]";
            // 
            // lblNombreEvento
            // 
            this.lblNombreEvento.AutoSize = true;
            this.lblNombreEvento.Location = new System.Drawing.Point(277, 134);
            this.lblNombreEvento.Name = "lblNombreEvento";
            this.lblNombreEvento.Size = new System.Drawing.Size(87, 13);
            this.lblNombreEvento.TabIndex = 17;
            this.lblNombreEvento.Text = "[Nombre Evento]";
            // 
            // lblDireccionEvento
            // 
            this.lblDireccionEvento.AutoSize = true;
            this.lblDireccionEvento.Location = new System.Drawing.Point(277, 185);
            this.lblDireccionEvento.Name = "lblDireccionEvento";
            this.lblDireccionEvento.Size = new System.Drawing.Size(95, 13);
            this.lblDireccionEvento.TabIndex = 20;
            this.lblDireccionEvento.Text = "[Dirección Evento]";
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(130, 384);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(43, 33);
            this.panel4.TabIndex = 6;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(88)))), ((int)(((byte)(70)))));
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(12, 223);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(49, 18);
            this.lblMenu.TabIndex = 21;
            this.lblMenu.Text = "Menú";
            // 
            // lstvMenu
            // 
            this.lstvMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPlatillo,
            this.colPorciones,
            this.colPU});
            this.lstvMenu.GridLines = true;
            this.lstvMenu.Location = new System.Drawing.Point(15, 254);
            this.lstvMenu.Name = "lstvMenu";
            this.lstvMenu.Size = new System.Drawing.Size(484, 124);
            this.lstvMenu.TabIndex = 22;
            this.lstvMenu.UseCompatibleStateImageBehavior = false;
            this.lstvMenu.View = System.Windows.Forms.View.Details;
            // 
            // colPlatillo
            // 
            this.colPlatillo.Text = "Platillo";
            this.colPlatillo.Width = 330;
            // 
            // colPorciones
            // 
            this.colPorciones.Text = "Porciones";
            this.colPorciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPorciones.Width = 66;
            // 
            // colPU
            // 
            this.colPU.Text = "Precio Unitario";
            this.colPU.Width = 83;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(464, 381);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(31, 13);
            this.lblSubtotal.TabIndex = 23;
            this.lblSubtotal.Text = "$$$$";
            // 
            // lblSubtotalA
            // 
            this.lblSubtotalA.AutoSize = true;
            this.lblSubtotalA.Location = new System.Drawing.Point(356, 381);
            this.lblSubtotalA.Name = "lblSubtotalA";
            this.lblSubtotalA.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotalA.TabIndex = 24;
            this.lblSubtotalA.Text = "Subtotal:";
            // 
            // lblIvaA
            // 
            this.lblIvaA.AutoSize = true;
            this.lblIvaA.Location = new System.Drawing.Point(378, 398);
            this.lblIvaA.Name = "lblIvaA";
            this.lblIvaA.Size = new System.Drawing.Size(27, 13);
            this.lblIvaA.TabIndex = 25;
            this.lblIvaA.Text = "IVA:";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Location = new System.Drawing.Point(464, 398);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(31, 13);
            this.lblIva.TabIndex = 26;
            this.lblIva.Text = "$$$$";
            // 
            // lblSeparador
            // 
            this.lblSeparador.AutoSize = true;
            this.lblSeparador.Location = new System.Drawing.Point(354, 404);
            this.lblSeparador.Name = "lblSeparador";
            this.lblSeparador.Size = new System.Drawing.Size(145, 13);
            this.lblSeparador.TabIndex = 27;
            this.lblSeparador.Text = "_______________________";
            // 
            // lblTotalA
            // 
            this.lblTotalA.AutoSize = true;
            this.lblTotalA.Location = new System.Drawing.Point(356, 421);
            this.lblTotalA.Name = "lblTotalA";
            this.lblTotalA.Size = new System.Drawing.Size(45, 13);
            this.lblTotalA.TabIndex = 28;
            this.lblTotalA.Text = "TOTAL:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(458, 421);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 13);
            this.lblTotal.TabIndex = 29;
            this.lblTotal.Text = "$$$$$";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 458);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(424, 458);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 31;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(343, 458);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 32;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(262, 458);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 33;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // Recibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(510, 493);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalA);
            this.Controls.Add(this.lblIva);
            this.Controls.Add(this.lblIvaA);
            this.Controls.Add(this.lblSubtotalA);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lstvMenu);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblDireccionEvento);
            this.Controls.Add(this.lblHoraEvento);
            this.Controls.Add(this.lblFechaEvento);
            this.Controls.Add(this.lblNombreEvento);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblEvento);
            this.Controls.Add(this.lblEmailCliente);
            this.Controls.Add(this.lblTelCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblFechaReciboA);
            this.Controls.Add(this.lblFolio);
            this.Controls.Add(this.lblFolioA);
            this.Controls.Add(this.lblFechaRecibo);
            this.Controls.Add(this.lblNombreComp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblInfoRecibo);
            this.Controls.Add(this.lblSeparador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Recibo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recibo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfoRecibo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombreComp;
        private System.Windows.Forms.Label lblFechaRecibo;
        private System.Windows.Forms.Label lblFolioA;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.Label lblFechaReciboA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblTelCliente;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblHoraEvento;
        private System.Windows.Forms.Label lblFechaEvento;
        private System.Windows.Forms.Label lblNombreEvento;
        private System.Windows.Forms.Label lblDireccionEvento;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.ListView lstvMenu;
        private System.Windows.Forms.ColumnHeader colPlatillo;
        private System.Windows.Forms.ColumnHeader colPorciones;
        private System.Windows.Forms.ColumnHeader colPU;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblSubtotalA;
        private System.Windows.Forms.Label lblIvaA;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblSeparador;
        private System.Windows.Forms.Label lblTotalA;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnAnterior;
    }
}