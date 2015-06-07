namespace Banquetes
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.pnlServicio = new System.Windows.Forms.Panel();
            this.lblInicioCliente = new System.Windows.Forms.Label();
            this.picCancelar = new System.Windows.Forms.PictureBox();
            this.picModificar = new System.Windows.Forms.PictureBox();
            this.picCrear = new System.Windows.Forms.PictureBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtCancelar = new Practica1_Calculadora.WaterMarkTextBox();
            this.txtModificar = new Practica1_Calculadora.WaterMarkTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCrear)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlServicio
            // 
            this.pnlServicio.Location = new System.Drawing.Point(122, 408);
            this.pnlServicio.Name = "pnlServicio";
            this.pnlServicio.Size = new System.Drawing.Size(18, 15);
            this.pnlServicio.TabIndex = 5;
            this.pnlServicio.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblInicioCliente
            // 
            this.lblInicioCliente.AutoSize = true;
            this.lblInicioCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(88)))), ((int)(((byte)(70)))));
            this.lblInicioCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicioCliente.ForeColor = System.Drawing.Color.White;
            this.lblInicioCliente.Location = new System.Drawing.Point(12, 12);
            this.lblInicioCliente.Name = "lblInicioCliente";
            this.lblInicioCliente.Size = new System.Drawing.Size(252, 18);
            this.lblInicioCliente.TabIndex = 13;
            this.lblInicioCliente.Text = "Servicio de Banquetes IntelliJED";
            // 
            // picCancelar
            // 
            this.picCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCancelar.Image = ((System.Drawing.Image)(resources.GetObject("picCancelar.Image")));
            this.picCancelar.Location = new System.Drawing.Point(36, 294);
            this.picCancelar.Name = "picCancelar";
            this.picCancelar.Size = new System.Drawing.Size(200, 100);
            this.picCancelar.TabIndex = 22;
            this.picCancelar.TabStop = false;
            this.picCancelar.Click += new System.EventHandler(this.picCancelar_Click);
            // 
            // picModificar
            // 
            this.picModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picModificar.Image = ((System.Drawing.Image)(resources.GetObject("picModificar.Image")));
            this.picModificar.Location = new System.Drawing.Point(36, 168);
            this.picModificar.Name = "picModificar";
            this.picModificar.Size = new System.Drawing.Size(200, 100);
            this.picModificar.TabIndex = 23;
            this.picModificar.TabStop = false;
            this.picModificar.Click += new System.EventHandler(this.picModificar_Click);
            // 
            // picCrear
            // 
            this.picCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCrear.Image = ((System.Drawing.Image)(resources.GetObject("picCrear.Image")));
            this.picCrear.Location = new System.Drawing.Point(36, 42);
            this.picCrear.Name = "picCrear";
            this.picCrear.Size = new System.Drawing.Size(200, 100);
            this.picCrear.TabIndex = 24;
            this.picCrear.TabStop = false;
            this.picCrear.Click += new System.EventHandler(this.picCrear_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(188, 401);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(48, 23);
            this.btnAdmin.TabIndex = 29;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(36, 400);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(48, 23);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtCancelar
            // 
            this.txtCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCancelar.Location = new System.Drawing.Point(36, 274);
            this.txtCancelar.Name = "txtCancelar";
            this.txtCancelar.Size = new System.Drawing.Size(200, 20);
            this.txtCancelar.TabIndex = 28;
            this.txtCancelar.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtCancelar.WaterMarkText = "Folio de evento a cancelar";
            // 
            // txtModificar
            // 
            this.txtModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtModificar.Location = new System.Drawing.Point(36, 148);
            this.txtModificar.Name = "txtModificar";
            this.txtModificar.Size = new System.Drawing.Size(200, 20);
            this.txtModificar.TabIndex = 27;
            this.txtModificar.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtModificar.WaterMarkText = "Folio de evento a modificar";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(276, 431);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.txtCancelar);
            this.Controls.Add(this.txtModificar);
            this.Controls.Add(this.picCrear);
            this.Controls.Add(this.picModificar);
            this.Controls.Add(this.picCancelar);
            this.Controls.Add(this.lblInicioCliente);
            this.Controls.Add(this.pnlServicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banquetes IntelliJED";
            ((System.ComponentModel.ISupportInitialize)(this.picCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCrear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlServicio;
        private System.Windows.Forms.Label lblInicioCliente;
        private System.Windows.Forms.PictureBox picCancelar;
        private System.Windows.Forms.PictureBox picModificar;
        private System.Windows.Forms.PictureBox picCrear;
        private Practica1_Calculadora.WaterMarkTextBox txtModificar;
        private Practica1_Calculadora.WaterMarkTextBox txtCancelar;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnSalir;
    }
}