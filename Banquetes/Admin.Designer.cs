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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPorRealizar
            // 
            this.lstPorRealizar.FormattingEnabled = true;
            this.lstPorRealizar.Location = new System.Drawing.Point(29, 93);
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
            this.lblPorRealizar.Location = new System.Drawing.Point(29, 77);
            this.lblPorRealizar.Name = "lblPorRealizar";
            this.lblPorRealizar.Size = new System.Drawing.Size(64, 13);
            this.lblPorRealizar.TabIndex = 2;
            this.lblPorRealizar.Text = "Por Realizar";
            // 
            // lblRealizados
            // 
            this.lblRealizados.AutoSize = true;
            this.lblRealizados.Location = new System.Drawing.Point(191, 77);
            this.lblRealizados.Name = "lblRealizados";
            this.lblRealizados.Size = new System.Drawing.Size(59, 13);
            this.lblRealizados.TabIndex = 3;
            this.lblRealizados.Text = "Realizados";
            // 
            // lstRealizados
            // 
            this.lstRealizados.FormattingEnabled = true;
            this.lstRealizados.Location = new System.Drawing.Point(194, 93);
            this.lstRealizados.Name = "lstRealizados";
            this.lstRealizados.Size = new System.Drawing.Size(159, 238);
            this.lstRealizados.TabIndex = 4;
            // 
            // lstCancelados
            // 
            this.lstCancelados.FormattingEnabled = true;
            this.lstCancelados.Location = new System.Drawing.Point(359, 93);
            this.lstCancelados.Name = "lstCancelados";
            this.lstCancelados.Size = new System.Drawing.Size(159, 238);
            this.lstCancelados.TabIndex = 6;
            // 
            // lblCancelados
            // 
            this.lblCancelados.AutoSize = true;
            this.lblCancelados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelados.Location = new System.Drawing.Point(356, 77);
            this.lblCancelados.Name = "lblCancelados";
            this.lblCancelados.Size = new System.Drawing.Size(63, 13);
            this.lblCancelados.TabIndex = 5;
            this.lblCancelados.Text = "Cancelados";
            // 
            // panel1
            // 
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(168, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 27);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblEventos
            // 
            this.lblEventos.AutoSize = true;
            this.lblEventos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(88)))), ((int)(((byte)(70)))));
            this.lblEventos.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventos.ForeColor = System.Drawing.Color.White;
            this.lblEventos.Location = new System.Drawing.Point(22, 50);
            this.lblEventos.Name = "lblEventos";
            this.lblEventos.Size = new System.Drawing.Size(67, 18);
            this.lblEventos.TabIndex = 0;
            this.lblEventos.Text = "Eventos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(29, 337);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 35);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar Evento";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(113, 337);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 35);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar Fecha de Evento";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(264, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 468);
            this.Controls.Add(this.groupBox1);
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
            this.Name = "Admin";
            this.Text = "Admin";
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}