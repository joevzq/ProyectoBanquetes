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
            this.pnlNombre = new System.Windows.Forms.Panel();
            this.lblNombreEntrada = new System.Windows.Forms.Label();
            this.lblIngredientes = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picEntrada)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(3, 0);
            this.lblDescripcion.MaximumSize = new System.Drawing.Size(190, 70);
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
            this.lstIngredientes.Location = new System.Drawing.Point(22, 112);
            this.lstIngredientes.Name = "lstIngredientes";
            this.lstIngredientes.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstIngredientes.Size = new System.Drawing.Size(167, 117);
            this.lstIngredientes.TabIndex = 19;
            // 
            // picEntrada
            // 
            this.picEntrada.Image = ((System.Drawing.Image)(resources.GetObject("picEntrada.Image")));
            this.picEntrada.Location = new System.Drawing.Point(15, 46);
            this.picEntrada.Name = "picEntrada";
            this.picEntrada.Size = new System.Drawing.Size(320, 320);
            this.picEntrada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picEntrada.TabIndex = 18;
            this.picEntrada.TabStop = false;
            // 
            // pnlNombre
            // 
            this.pnlNombre.Location = new System.Drawing.Point(422, 343);
            this.pnlNombre.Name = "pnlNombre";
            this.pnlNombre.Size = new System.Drawing.Size(22, 17);
            this.pnlNombre.TabIndex = 17;
            this.pnlNombre.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNombre_Paint);
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
            this.lblIngredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredientes.Location = new System.Drawing.Point(7, 96);
            this.lblIngredientes.Name = "lblIngredientes";
            this.lblIngredientes.Size = new System.Drawing.Size(91, 15);
            this.lblIngredientes.TabIndex = 21;
            this.lblIngredientes.Text = "Ingredientes:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(88)))), ((int)(((byte)(70)))));
            this.lblPrecio.Location = new System.Drawing.Point(144, 261);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(55, 29);
            this.lblPrecio.TabIndex = 22;
            this.lblPrecio.Text = "$45";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(466, 343);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(341, 343);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 24;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lstIngredientes);
            this.panel2.Controls.Add(this.lblDescripcion);
            this.panel2.Controls.Add(this.lblPrecio);
            this.panel2.Controls.Add(this.lblIngredientes);
            this.panel2.Location = new System.Drawing.Point(341, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 291);
            this.panel2.TabIndex = 25;
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(553, 383);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.picEntrada);
            this.Controls.Add(this.pnlNombre);
            this.Controls.Add(this.lblNombreEntrada);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Entrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información del platillo";
            ((System.ComponentModel.ISupportInitialize)(this.picEntrada)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ListBox lstIngredientes;
        private System.Windows.Forms.PictureBox picEntrada;
        private System.Windows.Forms.Panel pnlNombre;
        private System.Windows.Forms.Label lblNombreEntrada;
        private System.Windows.Forms.Label lblIngredientes;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Panel panel2;
    }
}