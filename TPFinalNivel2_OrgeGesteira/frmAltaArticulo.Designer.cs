namespace WindowsFormsApp1
{
    partial class frmAltaArticulo
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
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.tbcodigo = new System.Windows.Forms.TextBox();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.tbdescripcion = new System.Windows.Forms.TextBox();
            this.lblprecio = new System.Windows.Forms.Label();
            this.tbprecio = new System.Windows.Forms.TextBox();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lblmarca = new System.Windows.Forms.Label();
            this.lbltipo = new System.Windows.Forms.Label();
            this.cbmarca = new System.Windows.Forms.ComboBox();
            this.cbtipo = new System.Windows.Forms.ComboBox();
            this.tburl = new System.Windows.Forms.TextBox();
            this.lblurl = new System.Windows.Forms.Label();
            this.pbArticulo = new System.Windows.Forms.PictureBox();
            this.btnagregarimagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(50, 24);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(40, 13);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Codigo";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(50, 58);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Nombre";
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(50, 93);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbldescripcion.TabIndex = 2;
            this.lbldescripcion.Text = "Descripcion";
            // 
            // tbcodigo
            // 
            this.tbcodigo.Location = new System.Drawing.Point(119, 21);
            this.tbcodigo.Name = "tbcodigo";
            this.tbcodigo.Size = new System.Drawing.Size(100, 20);
            this.tbcodigo.TabIndex = 1;
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(119, 55);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(100, 20);
            this.tbnombre.TabIndex = 2;
            // 
            // tbdescripcion
            // 
            this.tbdescripcion.Location = new System.Drawing.Point(119, 90);
            this.tbdescripcion.Name = "tbdescripcion";
            this.tbdescripcion.Size = new System.Drawing.Size(100, 20);
            this.tbdescripcion.TabIndex = 3;
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(50, 127);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(37, 13);
            this.lblprecio.TabIndex = 6;
            this.lblprecio.Text = "Precio";
            // 
            // tbprecio
            // 
            this.tbprecio.Location = new System.Drawing.Point(119, 127);
            this.tbprecio.Name = "tbprecio";
            this.tbprecio.Size = new System.Drawing.Size(100, 20);
            this.tbprecio.TabIndex = 4;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(53, 279);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 8;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(159, 279);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 9;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Location = new System.Drawing.Point(50, 194);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(37, 13);
            this.lblmarca.TabIndex = 1;
            this.lblmarca.Text = "Marca";
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Location = new System.Drawing.Point(50, 228);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(52, 13);
            this.lbltipo.TabIndex = 5;
            this.lbltipo.Text = "Categoria";
            // 
            // cbmarca
            // 
            this.cbmarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmarca.FormattingEnabled = true;
            this.cbmarca.Location = new System.Drawing.Point(119, 194);
            this.cbmarca.Name = "cbmarca";
            this.cbmarca.Size = new System.Drawing.Size(121, 21);
            this.cbmarca.TabIndex = 6;
            // 
            // cbtipo
            // 
            this.cbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.Location = new System.Drawing.Point(119, 228);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(121, 21);
            this.cbtipo.TabIndex = 7;
            // 
            // tburl
            // 
            this.tburl.Location = new System.Drawing.Point(119, 163);
            this.tburl.Name = "tburl";
            this.tburl.Size = new System.Drawing.Size(100, 20);
            this.tburl.TabIndex = 5;
            this.tburl.Leave += new System.EventHandler(this.tburl_Leave);
            // 
            // lblurl
            // 
            this.lblurl.AutoSize = true;
            this.lblurl.Location = new System.Drawing.Point(50, 166);
            this.lblurl.Name = "lblurl";
            this.lblurl.Size = new System.Drawing.Size(58, 13);
            this.lblurl.TabIndex = 14;
            this.lblurl.Text = "Url Imagen";
            // 
            // pbArticulo
            // 
            this.pbArticulo.Location = new System.Drawing.Point(312, 24);
            this.pbArticulo.Name = "pbArticulo";
            this.pbArticulo.Size = new System.Drawing.Size(262, 278);
            this.pbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArticulo.TabIndex = 16;
            this.pbArticulo.TabStop = false;
            // 
            // btnagregarimagen
            // 
            this.btnagregarimagen.Location = new System.Drawing.Point(249, 161);
            this.btnagregarimagen.Name = "btnagregarimagen";
            this.btnagregarimagen.Size = new System.Drawing.Size(41, 23);
            this.btnagregarimagen.TabIndex = 17;
            this.btnagregarimagen.Text = "+";
            this.btnagregarimagen.UseVisualStyleBackColor = true;
            this.btnagregarimagen.Click += new System.EventHandler(this.btnagregarimagen_Click);
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 331);
            this.Controls.Add(this.btnagregarimagen);
            this.Controls.Add(this.pbArticulo);
            this.Controls.Add(this.tburl);
            this.Controls.Add(this.lblurl);
            this.Controls.Add(this.cbtipo);
            this.Controls.Add(this.cbmarca);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.lblmarca);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.tbprecio);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.tbdescripcion);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.tbcodigo);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblcodigo);
            this.Name = "frmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Pokemon";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.TextBox tbcodigo;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.TextBox tbdescripcion;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.TextBox tbprecio;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.ComboBox cbmarca;
        private System.Windows.Forms.ComboBox cbtipo;
        private System.Windows.Forms.TextBox tburl;
        private System.Windows.Forms.Label lblurl;
        private System.Windows.Forms.PictureBox pbArticulo;
        private System.Windows.Forms.Button btnagregarimagen;
    }
}