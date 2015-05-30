namespace Banquetes
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.lstPorRealizar = new System.Windows.Forms.ListBox();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblPorRealizar = new System.Windows.Forms.Label();
            this.lblRealizados = new System.Windows.Forms.Label();
            this.lstRealizados = new System.Windows.Forms.ListBox();
            this.lstCancelados = new System.Windows.Forms.ListBox();
            this.lblCancelados = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEventos = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.grpFecha = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPorRealizar
            // 
            this.lstPorRealizar.FormattingEnabled = true;
            this.lstPorRealizar.Location = new System.Drawing.Point(29, 78);
            this.lstPorRealizar.Name = "lstPorRealizar";
            this.lstPorRealizar.Size = new System.Drawing.Size(159, 238);
            this.lstPorRealizar.TabIndex = 0;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Location = new System.Drawing.Point(12, 9);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(110, 13);
            this.lblBienvenido.TabIndex = 1;
            this.lblBienvenido.Text = "Bienvenido, [nombre].";
            // 
            // lblPorRealizar
            // 
            this.lblPorRealizar.AutoSize = true;
            this.lblPorRealizar.Location = new System.Drawing.Point(29, 62);
            this.lblPorRealizar.Name = "lblPorRealizar";
            this.lblPorRealizar.Size = new System.Drawing.Size(64, 13);
            this.lblPorRealizar.TabIndex = 2;
            this.lblPorRealizar.Text = "Por Realizar";
            // 
            // lblRealizados
            // 
            this.lblRealizados.AutoSize = true;
            this.lblRealizados.Location = new System.Drawing.Point(191, 62);
            this.lblRealizados.Name = "lblRealizados";
            this.lblRealizados.Size = new System.Drawing.Size(59, 13);
            this.lblRealizados.TabIndex = 3;
            this.lblRealizados.Text = "Realizados";
            // 
            // lstRealizados
            // 
            this.lstRealizados.FormattingEnabled = true;
            this.lstRealizados.Location = new System.Drawing.Point(194, 78);
            this.lstRealizados.Name = "lstRealizados";
            this.lstRealizados.Size = new System.Drawing.Size(159, 238);
            this.lstRealizados.TabIndex = 4;
            // 
            // lstCancelados
            // 
            this.lstCancelados.FormattingEnabled = true;
            this.lstCancelados.Location = new System.Drawing.Point(359, 78);
            this.lstCancelados.Name = "lstCancelados";
            this.lstCancelados.Size = new System.Drawing.Size(159, 238);
            this.lstCancelados.TabIndex = 6;
            // 
            // lblCancelados
            // 
            this.lblCancelados.AutoSize = true;
            this.lblCancelados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelados.Location = new System.Drawing.Point(356, 62);
            this.lblCancelados.Name = "lblCancelados";
            this.lblCancelados.Size = new System.Drawing.Size(63, 13);
            this.lblCancelados.TabIndex = 5;
            this.lblCancelados.Text = "Cancelados";
            // 
            // panel1
            // 
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(513, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(56, 27);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblEventos
            // 
            this.lblEventos.AutoSize = true;
            this.lblEventos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(88)))), ((int)(((byte)(70)))));
            this.lblEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventos.ForeColor = System.Drawing.Color.White;
            this.lblEventos.Location = new System.Drawing.Point(22, 37);
            this.lblEventos.Name = "lblEventos";
            this.lblEventos.Size = new System.Drawing.Size(69, 18);
            this.lblEventos.TabIndex = 0;
            this.lblEventos.Text = "Eventos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Location = new System.Drawing.Point(29, 322);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 35);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar Evento";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(113, 322);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 35);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar Fecha de Evento";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // grpFecha
            // 
            this.grpFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpFecha.Controls.Add(this.btnGuardar);
            this.grpFecha.Controls.Add(this.dateTimePicker1);
            this.grpFecha.Location = new System.Drawing.Point(303, 322);
            this.grpFecha.Name = "grpFecha";
            this.grpFecha.Size = new System.Drawing.Size(215, 83);
            this.grpFecha.TabIndex = 10;
            this.grpFecha.TabStop = false;
            this.grpFecha.Text = "Editar Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 19);
            this.dateTimePicker1.MaxDate = new System.DateTime(2019, 12, 25, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2015, 3, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(131, 45);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 25);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(29, 382);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(549, 418);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grpFecha);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblEventos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstCancelados);
            this.Controls.Add(this.lblCancelados);
            this.Controls.Add(this.lstRealizados);
            this.Controls.Add(this.lblRealizados);
            this.Controls.Add(this.lblPorRealizar);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.lstPorRealizar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.Text = "Banquetes Haquers";
            this.grpFecha.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPorRealizar;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label lblPorRealizar;
        private System.Windows.Forms.Label lblRealizados;
        private System.Windows.Forms.ListBox lstRealizados;
        private System.Windows.Forms.ListBox lstCancelados;
        private System.Windows.Forms.Label lblCancelados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEventos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox grpFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
    }
}