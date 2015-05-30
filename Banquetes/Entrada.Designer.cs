namespace Banquetes
{
    partial class Entrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrada));
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lstIngredientes = new System.Windows.Forms.ListBox();
            this.picEntrada = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombreEntrada = new System.Windows.Forms.Label();
            this.lblIngredientes = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(271, 46);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(186, 39);
            this.lblDescripcion.TabIndex = 20;
            this.lblDescripcion.Text = "[Descripcion de la entrada, se espera \r\nque el largo de este texto sea entre \r\n10" +
    "0 y 300 caracteres]";
            // 
            // lstIngredientes
            // 
            this.lstIngredientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstIngredientes.FormattingEnabled = true;
            this.lstIngredientes.Items.AddRange(new object[] {
            "[Ingrediente 1]",
            "[Ingrediente 2]",
            "[Ingrediente 3]",
            "[Ingrediente 4]",
            "[Ingrediente 5]",
            "[Ingrediente 6]",
            "[Ingrediente 7]",
            "[Ingrediente 8]"});
            this.lstIngredientes.Location = new System.Drawing.Point(280, 135);
            this.lstIngredientes.Name = "lstIngredientes";
            this.lstIngredientes.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstIngredientes.Size = new System.Drawing.Size(177, 130);
            this.lstIngredientes.TabIndex = 19;
            // 
            // picEntrada
            // 
            this.picEntrada.Image = ((System.Drawing.Image)(resources.GetObject("picEntrada.Image")));
            this.picEntrada.Location = new System.Drawing.Point(15, 46);
            this.picEntrada.Name = "picEntrada";
            this.picEntrada.Size = new System.Drawing.Size(250, 250);
            this.picEntrada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picEntrada.TabIndex = 18;
            this.picEntrada.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(435, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(22, 17);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblNombreEntrada
            // 
            this.lblNombreEntrada.AutoSize = true;
            this.lblNombreEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(88)))), ((int)(((byte)(70)))));
            this.lblNombreEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEntrada.ForeColor = System.Drawing.Color.White;
            this.lblNombreEntrada.Location = new System.Drawing.Point(12, 12);
            this.lblNombreEntrada.Name = "lblNombreEntrada";
            this.lblNombreEntrada.Size = new System.Drawing.Size(180, 18);
            this.lblNombreEntrada.TabIndex = 16;
            this.lblNombreEntrada.Text = "[Nombre de la entrada]";
            // 
            // lblIngredientes
            // 
            this.lblIngredientes.AutoSize = true;
            this.lblIngredientes.Location = new System.Drawing.Point(271, 113);
            this.lblIngredientes.Name = "lblIngredientes";
            this.lblIngredientes.Size = new System.Drawing.Size(68, 13);
            this.lblIngredientes.TabIndex = 21;
            this.lblIngredientes.Text = "Ingredientes:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(88)))), ((int)(((byte)(70)))));
            this.lblPrecio.Location = new System.Drawing.Point(416, 240);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(51, 25);
            this.lblPrecio.TabIndex = 22;
            this.lblPrecio.Text = "$45";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(392, 273);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(274, 273);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 24;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 312);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblIngredientes);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lstIngredientes);
            this.Controls.Add(this.picEntrada);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNombreEntrada);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Entrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información del platillo";
            ((System.ComponentModel.ISupportInitialize)(this.picEntrada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ListBox lstIngredientes;
        private System.Windows.Forms.PictureBox picEntrada;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombreEntrada;
        private System.Windows.Forms.Label lblIngredientes;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRegresar;
    }
}