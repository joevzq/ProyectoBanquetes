namespace Banquetes
{
    partial class InicioCliente
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtCancelar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInicioCliente = new System.Windows.Forms.Label();
            this.txtEditar = new System.Windows.Forms.TextBox();
            this.lblEdi = new System.Windows.Forms.Label();
            this.lblCan = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnRegresarC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbEditar = new System.Windows.Forms.GroupBox();
            this.gbCancelar = new System.Windows.Forms.GroupBox();
            this.btnEditarE = new System.Windows.Forms.Button();
            this.btnCancelarE = new System.Windows.Forms.Button();
            this.gbEditar.SuspendLayout();
            this.gbCancelar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(80, 39);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(97, 23);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo Evento";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(129, 37);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar Evento";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(129, 37);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Editar Evento";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtCancelar
            // 
            this.txtCancelar.Location = new System.Drawing.Point(9, 39);
            this.txtCancelar.Name = "txtCancelar";
            this.txtCancelar.Size = new System.Drawing.Size(114, 20);
            this.txtCancelar.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(8, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(18, 15);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "*Ingrese el folio del evento a editar o cancelar";
            // 
            // lblInicioCliente
            // 
            this.lblInicioCliente.AutoSize = true;
            this.lblInicioCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(88)))), ((int)(((byte)(70)))));
            this.lblInicioCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicioCliente.ForeColor = System.Drawing.Color.White;
            this.lblInicioCliente.Location = new System.Drawing.Point(5, 9);
            this.lblInicioCliente.Name = "lblInicioCliente";
            this.lblInicioCliente.Size = new System.Drawing.Size(90, 18);
            this.lblInicioCliente.TabIndex = 13;
            this.lblInicioCliente.Text = "Bienvenido";
            // 
            // txtEditar
            // 
            this.txtEditar.Location = new System.Drawing.Point(9, 39);
            this.txtEditar.Name = "txtEditar";
            this.txtEditar.Size = new System.Drawing.Size(114, 20);
            this.txtEditar.TabIndex = 14;
            // 
            // lblEdi
            // 
            this.lblEdi.AutoSize = true;
            this.lblEdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(88)))), ((int)(((byte)(70)))));
            this.lblEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdi.ForeColor = System.Drawing.Color.White;
            this.lblEdi.Location = new System.Drawing.Point(6, 16);
            this.lblEdi.Name = "lblEdi";
            this.lblEdi.Size = new System.Drawing.Size(126, 18);
            this.lblEdi.TabIndex = 15;
            this.lblEdi.Text = "Folio de Evento";
            // 
            // lblCan
            // 
            this.lblCan.AutoSize = true;
            this.lblCan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(88)))), ((int)(((byte)(70)))));
            this.lblCan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCan.ForeColor = System.Drawing.Color.White;
            this.lblCan.Location = new System.Drawing.Point(6, 16);
            this.lblCan.Name = "lblCan";
            this.lblCan.Size = new System.Drawing.Size(126, 18);
            this.lblCan.TabIndex = 16;
            this.lblCan.Text = "Folio de Evento";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(89, 79);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(66, 23);
            this.btnRegresar.TabIndex = 17;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnRegresarC
            // 
            this.btnRegresarC.Location = new System.Drawing.Point(77, 79);
            this.btnRegresarC.Name = "btnRegresarC";
            this.btnRegresarC.Size = new System.Drawing.Size(66, 23);
            this.btnRegresarC.TabIndex = 18;
            this.btnRegresarC.Text = "Regresar";
            this.btnRegresarC.UseVisualStyleBackColor = true;
            this.btnRegresarC.Click += new System.EventHandler(this.btnRegresarC_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "*Ingrese el folio del evento a editar o cancelar";
            // 
            // gbEditar
            // 
            this.gbEditar.Controls.Add(this.lblCan);
            this.gbEditar.Controls.Add(this.btnModificar);
            this.gbEditar.Controls.Add(this.label1);
            this.gbEditar.Controls.Add(this.txtEditar);
            this.gbEditar.Controls.Add(this.btnRegresar);
            this.gbEditar.Location = new System.Drawing.Point(8, 39);
            this.gbEditar.Name = "gbEditar";
            this.gbEditar.Size = new System.Drawing.Size(238, 113);
            this.gbEditar.TabIndex = 20;
            this.gbEditar.TabStop = false;
            this.gbEditar.Text = "Editar Evento";
            this.gbEditar.Visible = false;
            // 
            // gbCancelar
            // 
            this.gbCancelar.Controls.Add(this.lblEdi);
            this.gbCancelar.Controls.Add(this.btnCancelar);
            this.gbCancelar.Controls.Add(this.label2);
            this.gbCancelar.Controls.Add(this.txtCancelar);
            this.gbCancelar.Controls.Add(this.btnRegresarC);
            this.gbCancelar.Location = new System.Drawing.Point(8, 33);
            this.gbCancelar.Name = "gbCancelar";
            this.gbCancelar.Size = new System.Drawing.Size(238, 113);
            this.gbCancelar.TabIndex = 21;
            this.gbCancelar.TabStop = false;
            this.gbCancelar.Text = "Cancelar Evento";
            this.gbCancelar.Visible = false;
            // 
            // btnEditarE
            // 
            this.btnEditarE.Location = new System.Drawing.Point(12, 84);
            this.btnEditarE.Name = "btnEditarE";
            this.btnEditarE.Size = new System.Drawing.Size(100, 23);
            this.btnEditarE.TabIndex = 18;
            this.btnEditarE.Text = "Editar Evento";
            this.btnEditarE.UseVisualStyleBackColor = true;
            this.btnEditarE.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCancelarE
            // 
            this.btnCancelarE.Location = new System.Drawing.Point(140, 84);
            this.btnCancelarE.Name = "btnCancelarE";
            this.btnCancelarE.Size = new System.Drawing.Size(100, 23);
            this.btnCancelarE.TabIndex = 20;
            this.btnCancelarE.Text = "Cancelar Evento";
            this.btnCancelarE.UseVisualStyleBackColor = true;
            this.btnCancelarE.Click += new System.EventHandler(this.btnCancelarE_Click);
            // 
            // InicioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 166);
            this.Controls.Add(this.btnCancelarE);
            this.Controls.Add(this.btnEditarE);
            this.Controls.Add(this.gbCancelar);
            this.Controls.Add(this.gbEditar);
            this.Controls.Add(this.lblInicioCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNuevo);
            this.Name = "InicioCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InicioCliente";
            this.gbEditar.ResumeLayout(false);
            this.gbEditar.PerformLayout();
            this.gbCancelar.ResumeLayout(false);
            this.gbCancelar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInicioCliente;
        private System.Windows.Forms.TextBox txtEditar;
        private System.Windows.Forms.Label lblEdi;
        private System.Windows.Forms.Label lblCan;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnRegresarC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbEditar;
        private System.Windows.Forms.GroupBox gbCancelar;
        private System.Windows.Forms.Button btnEditarE;
        private System.Windows.Forms.Button btnCancelarE;
    }
}